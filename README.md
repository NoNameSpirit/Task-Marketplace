# Task Marketplace

Task marketplace: customers publish tasks, executors respond, get assigned, chat, attach files, and receive ratings. The customer rates the executor after completion.

- .NET 10, 
- ASP.NET Core: Web API, Blazor Web App (Interactive Server).
- EF Core (SQL Server)
- MediatR (CQRS), 
- JWT, 
- Docker Compose.

# Requirements

- .NET 10 SDK 
- Docker Desktop 

##  Solution Structure

```text
Task Marketplace/
├── Domain/ 			# Entities, enums, consts, repo interfaces
├── Application/ 		# Use Cases (MediatR), mapping, services (hasher, JWT, files)
├── Infrastructure/ 	# EF Core, DbContext, repos, migrations
├── Shared/ 			# Request/response DTOs, Result<T>, PagedResult<T>, enums
├── Web Api/ 			# REST API, controllers, JWT-auth, Swagger
└── Blazor Web App/ 	# UI-client (Interactive Server), serivce-senders
```

# Start up:

1. Step: .env

- change .env-example and rename into .env (Change all variables in <...>):
```
# AppConfig.
AppConfig__ConnectionString=Server=sqlserver;Database=ProjectTaskDb;User Id=sa;Password=${AppConfig__Password};TrustServerCertificate=True;
AppConfig__Password=<YOUR_PASSWORD>

# JwtSettings.
JwtSettings__Key=<LONG_KEY_MIN_LENGTH_32>

# ApiSettings.
ApiSettings__ApiUrl=http://web_api:8080
```

2. Step: run app

	2.1. Go to the root file, open CMD

	2.2. Open Docker

	2.3. Write commands into CMD

```bash
docker-compose down -v

docker-compose up --build
docker ps
```

### 3. Urls

| Service | URL |
|---|---|
| Swagger | http://localhost:7025/swagger/index.html |
| client1 | http://localhost:5020/ |
| client2 | http://localhost:5021/ |

# Set admin role 
By default, registration creates only Customer or Executor (the Admin role is forbidden in User.Create). To grant administrator rights:
- set correct, container_name, db password, db, account_login:
```bash
docker exec -it projecttask-sqlserver /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P "<YOUR_PASSWORD_FROM_ENV>" -C -Q "UPDATE ProjectTaskDb.dbo.Users SET Role = 2 WHERE Name = 'YOUR_LOGIN'"
```

## Main Scenarios

1. **Registration / login** — `/register`, `/login`. The JWT is stored in `localStorage` and sent as a `Bearer` header.
2. **Customer** — creates a task (`/tasks`), views responses, assigns an executor, marks the task as done and rates the executor, chats, attaches files.
3. **Executor** — browses published tasks (`/tasks`), responds, and after assignment — `/my-assigned`, chat, attachments.
4. **Admin** — `/admin/users` (roles, blocking, deletion), `/admin/actions` (activity log).