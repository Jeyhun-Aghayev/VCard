using System.Text;

namespace CSharp.VCardCreation.Models;

public class VCardCreation
{
    public static void updateVCardContents(
        string firstName,
        string lastName,
        string email,
        string phone,
        string id,
        string country,
        string city)
    {
        // vCard içeriğini oluşturmak için StringBuilder kullanılır.
        StringBuilder vCard = new StringBuilder();
        vCard.Append("BEGIN:VCARD");
        vCard.AppendLine();
        vCard.Append("VERSION:2.1");
        vCard.AppendLine();
        vCard.Append($"FN:{firstName} {lastName}");
        vCard.AppendLine();
        vCard.AppendLine($"EMAIL;TYPE=work:{email}");
        vCard.AppendLine($"TEL;TYPE=work:{phone}");
        vCard.AppendLine($"UID:{id}");
        vCard.AppendLine($"ADR;TYPE=WORK:;;{country};;{city}");
        vCard.Append("END:VCARD");

        // Oluşturulan vCard içeriğiyle vCard dosyası oluşturan metot
        createVCard(vCard, firstName, lastName, id);
    }

    public static void createVCard
    (StringBuilder vCard,
        string firstName,
        string lastName,
        string id)

    {
        string fileName = $"{firstName}.{lastName}-{id}.vcf";
        // Masaüstü yolunu alır.
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        // Dosya yolunu birleştirir.
        string filePath = Path.Combine(desktopPath, fileName);
        // vCard içeriği dosyaya yazılır.
        File.WriteAllText(filePath, vCard.ToString());
    }
}