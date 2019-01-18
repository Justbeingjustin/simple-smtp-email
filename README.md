# simple-smtp-email

### Table of Contents
**[Available For](#available-for)**<br>
**[Nuget](#nuget)**<br>
**[Usage](#usage)**<br>
**[Contributing](#contributing)**<br>

## Available For
- .NET Standard 2.0
- .NET 4.6.1
- .NET 4.5

## Nuget

 ```
    PM> Install-Package simple-smtp-email
```


## Usage

You can simply create an email object with email details and send an email. 

```csharp
using SimpleEmail;
using SimpleEmail.Models;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var email = new Email(new GoogleEmailDetails()
            {
                To = "test@gmail.com",
                From = "test@gmail.com",
                Subject = "subject",
                Body = "This is a test body",
                GoogleUserName = "test@gmail.com",
                GooglePassword = "test123"
            });

            email.SendMail();
        }
    }
}
```


## Contributing

Pull requests are welcome. 

For large changes, please open an issue first to discuss what you would like to add.
