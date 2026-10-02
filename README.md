- Start up:
```bash
docker-compose down -v

docker-compose up --build
docker ps
```

- SWAGGER: 
http://localhost:7025/swagger/index.html

- Set admin role (set correct, container_name, db password, db, account_login):
```bash
docker exec -it projecttask-sqlserver /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "StrongP@ssw0rd123!" -C -Q "UPDATE ProjectTaskDb.dbo.Users SET Role = 2 WHERE Name = 'YOUR_LOGIN'"
```