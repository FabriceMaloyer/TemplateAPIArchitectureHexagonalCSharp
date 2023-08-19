Pensez a se faire un db context dans l'infra et l'ajouter au program
builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer("Server=<localhost>;Database=<TemplateHexagonaAPIDB>;User=<sa>;Password=<Password1>"));

il faut installer ENtityFramework Core, Relationnal, Tools et SQLServer

Les commandes a executer depuis le gestionnaire de package nuget :
Sur le projet qui contient la DB (infrastructure) :
Add-Migration 'nom de la migration'
update-database 

