Développement de l'api.

Avant toute chose nous allosn veillez à ce que vous remplissez bien les pré requis pour pouvoir commencer a développer ce mini projet.

- Prérequies ( supposons que vous avez une Debian like )

  ```bash
  wget https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
  sudo dpkg -i packages-microsoft-prod.deb
  rm packages-microsoft-prod.deb
  ```
  ```bash
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-8.0
  ```
  ```bash
  sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-8.0
  ```

Une fois que dotnet est installé nous allons installer le cli dotnet entity framework

```bash
dotnet tool install --global dotnet-ef --version 8.0.1
```

Ensuite nous allons générer la solution 

```bash
dotnet new sln --name Bibliotheque
```

Puis les packages pour mettre en place l'architecture

```bash
dotnet new console --framework net8.0 -o Bibliotheque.Entity
dotnet new console --framework net8.0 -o Bibliotheque.Business
dotnet new console --framework net8.0 -o Bibliotheque.Repository
dotnet new webapi  --framework net8.0 -o Bibliotheque.Api
```

Une fois que l'architecture est mise en place nous allons installer les packages necessaire au bon fonctionnement de notre futur projet

```bash
dotnet add package Microsoft.AspNetCore.OpenApi --version 8.0.1
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.1
dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.1
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 8.0.0
dotnet add package Swashbuckle.AspNetCore --version 6.5.0
dotnet add package Pomelo.EntityFrameworkCore.MySql.Design --version 1.1.2
```



