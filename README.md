docker-compose down -v

docker-compose up -d
docker ps

dotnet ef database update --project Infrastructure --startup-project "Web Api"

https://localhost:7025/swagger/index.html
