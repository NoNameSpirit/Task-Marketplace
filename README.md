# Start up:

1. Step - .env

- change .env-example and rename into .env

	1.1. .env-example:
Change all variables in <...> 
```
# AppConfig.
AppConfig__ConnectionString=Server=sqlserver;Database=ProjectTaskDb;User Id=sa;Password=${AppConfig__Password};TrustServerCertificate=True;
AppConfig__Password=<YOUR_PASSWORD>

# JwtSettings.
JwtSettings__Key=<LONG_KEY_MIN_LENGTH_32>

# ApiSettings.
ApiSettings__ApiUrl=http://web_api:8080
```
	1.2. rename .env-example into .env

2. Step - run app

	2.1. Go to the root file, open CMD

	2.2. Open Docker

	2.3. Write commands into CMD
```bash
docker-compose down -v

docker-compose up --build
docker ps
```

# Swagger and Clients: 
1 Open Swagger:
- http://localhost:7025/swagger/index.html

2 Open Clients: 
- http://localhost:5021/
- http://localhost:5020/

# ?? 
If something goes wrong, try checking Docker and running the container that is currently not working correctly
OR
one more repeat of using 
```
docker-compose up --build
```

# Set admin role 
- (set correct, container_name, db password, db, account_login):
```bash
docker exec -it projecttask-sqlserver /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "<YOUR_PASSWORD_FROM_ENV>" -C -Q "UPDATE ProjectTaskDb.dbo.Users SET Role = 2 WHERE Name = 'YOUR_LOGIN'"
```
