### Comandos de Migration

Add-Magration "Nome" - Cria os arquivos na pasta migrations
Update-DataBase "Nome" - Atualiza o banco de dados com as migrations


comando de instalação do RabitMQ (portas padrão)
docker run -d --hostname rabbit-host --name rabbit-webstore -p 15672:15672 -p 5672:5672 rabbitmq:management

### Migrations de Pedidios
Add-Migration Voucher -Context PedidosContext -StartupProject WSE.Pedidos.API
Update-Database -StartupProject WSE.Pedidos.API

### Configuração do SwaggerGen
```C#
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "Web Store Enterprise Pedidos API",
                    Description = "Esta API faz parte do projeto Web Store Enterprise Applications.",
                    Contact = new OpenApiContact() { Name = "Stanley Dias Paulo", Email = "stanley.dias.paulo@gmail.com" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Insira o token JWT desta maneira: Bearer {seu token}",
                    Name = "Authorization",
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });

            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
        }
    }
```
### Instalação de pacote NetDevPack WSE.Core
```csharp
    Install-Package NetDevPack -Version 1.1.0
```
### Migration do carrinho de compras >> Add Voucher de desconto.
Add-Migration Voucher -StartupProject WSE.Carrinho.API
Update-Database Voucher -StartupProject WSE.Carrinho.API


#### pode estar diferente do original
Add-Migration pedidos -StartupProject WSE.Pedidos.API


### Instalação do dapper (API Catalago)
Install-Package dapper 2.0.35
