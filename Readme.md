# <center>```C# VCard Creation from Random User API```</center>


> ```This project is designed to fetch user data from the Random User API and generate VCard (.vcf) files for each user based on the specified count.```

# <center> ```Requirements``` </center>

> - [Newtonsoft.Json NuGet package](https://www.nuget.org/packages/newtonsoft.json/)

# <center> ```Features```  </center>

>### ```RequestApi Class:```
>- ```Fetches user data from the Random User API based on user input.```
>- ``` Uses HttpClient to send a request to the API ```
>- ``` Checks if the API request was successful with response.EnsureSuccessStatusCode(). If not, throws the HTTP request exception. ```
>- ```Deserializes the response body using Newtonsoft.Json into a VCard Class```

>### ```ExceptionHandling Class: ```
>- ```Defines a custom exception (UserLimitException) for handling user limit exceeded scenarios when fetching data from the API.```

>### ```VCardCreation Class:```
>- ``` Provides methods to create VCard (.vcf) files using StringBuilder. ```
>- ```Formats user information into VCard format ```
> - ```Saves (.vcf) files to the desktop directory.```