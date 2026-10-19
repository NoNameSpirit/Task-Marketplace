# Project Bundle

- Root:
	 `D:\########University########\4 курс\Курсач\Task Marketplace`
- Output: `D:\########University########\4 курс\Курсач\Task Marketplace\Task Marketplace_bundle.md`
- Files included: `308`
- Total size: `490,4 KB`
- Max file size: `1,0 MB`

## File List

```text
.editconfig [9,6 KB]
.env-example [310 B]
.gitignore [7,8 KB]
Application/Application.csproj [702 B]
Application/Attachments/Commands/DeleteAttachment/DeleteAttachmentCommand.cs [197 B]
Application/Attachments/Commands/DeleteAttachment/DeleteAttachmentHandler.cs [1,8 KB]
Application/Attachments/Commands/UploadAttachment/UploadAttachmentCommand.cs [337 B]
Application/Attachments/Commands/UploadAttachment/UploadAttachmentHandler.cs [3,2 KB]
Application/Attachments/Queries/GetAttachmentFile/GetAttachmentFileHandler.cs [2,1 KB]
Application/Attachments/Queries/GetAttachmentFile/GetAttachmentFileQuery.cs [263 B]
Application/Attachments/Queries/GetTaskAttachments/GetTaskAttachmentsHandler.cs [1,0 KB]
Application/Attachments/Queries/GetTaskAttachments/GetTaskAttachmentsQuery.cs [243 B]
Application/Behaviors/TransactionBehaviour.cs [962 B]
Application/Behaviors/UserActionLoggingBehavior.cs [1,4 KB]
Application/Chats/Commands/AddMessage/AddMessageCommand.cs [318 B]
Application/Chats/Commands/AddMessage/AddMessageHandler.cs [2,4 KB]
Application/Chats/Commands/Create/CreateChatCommand.cs [348 B]
Application/Chats/Commands/Create/CreateChatHandler.cs [2,3 KB]
Application/Chats/Commands/Delete/DeleteChatCommand.cs [296 B]
Application/Chats/Commands/Delete/DeleteChatHandler.cs [1,9 KB]
Application/Chats/Queries/GetById/GetChatByIdHandler.cs [1,2 KB]
Application/Chats/Queries/GetById/GetChatByIdQuery.cs [215 B]
Application/Chats/Queries/GetByTaskId/GetChatByTaskIdHandler.cs [2,2 KB]
Application/Chats/Queries/GetByTaskId/GetChatByTaskIdQuery.cs [221 B]
Application/Chats/Queries/GetWithMessages/GetChatWithMessagesHandler.cs [1,2 KB]
Application/Chats/Queries/GetWithMessages/GetChatWithMessagesQuery.cs [229 B]
Application/Common/LogActionAttribute.cs [423 B]
Application/Interfaces/ICurrentUser.cs [130 B]
Application/Mappers/ChatMapper.cs [627 B]
Application/Mappers/ProjectTaskMapper.cs [1,6 KB]
Application/Mappers/TaskAttachmentMapper.cs [670 B]
Application/Mappers/UserMapper.cs [767 B]
Application/ProjectTasks/Commands/AssignExecutor/AssignExecutorCommand.cs [349 B]
Application/ProjectTasks/Commands/AssignExecutor/AssignExecutorHandler.cs [1,4 KB]
Application/ProjectTasks/Commands/Cancel/CancelProjectTaskCommand.cs [319 B]
Application/ProjectTasks/Commands/Cancel/CancelProjectTaskHandler.cs [1,3 KB]
Application/ProjectTasks/Commands/Create/CreateProjectTaskCommand.cs [486 B]
Application/ProjectTasks/Commands/Create/CreateProjectTaskHandler.cs [1,7 KB]
Application/ProjectTasks/Commands/Delete/DeleteProjectTaskCommand.cs [317 B]
Application/ProjectTasks/Commands/Delete/DeleteProjectTaskHandler.cs [1,3 KB]
Application/ProjectTasks/Commands/MarkAsDone/MarkAsDoneCommand.cs [339 B]
Application/ProjectTasks/Commands/MarkAsDone/MarkAsDoneHandler.cs [2,1 KB]
Application/ProjectTasks/Commands/RespondToTask/RespondToTaskCommand.cs [324 B]
Application/ProjectTasks/Commands/RespondToTask/RespondToTaskHandler.cs [1,3 KB]
Application/ProjectTasks/Commands/Update/UpdateProjectTaskCommand.cs [445 B]
Application/ProjectTasks/Commands/Update/UpdateProjectTaskHandler.cs [1,5 KB]
Application/ProjectTasks/Queries/GetAssigned/GetAssignedTasksHandler.cs [1,3 KB]
Application/ProjectTasks/Queries/GetAssigned/GetAssignedTasksQuery.cs [296 B]
Application/ProjectTasks/Queries/GetByCustomer/GetTasksByCustomerHandler.cs [1,2 KB]
Application/ProjectTasks/Queries/GetByCustomer/GetTasksByCustomerQuery.cs [305 B]
Application/ProjectTasks/Queries/GetById/GetProjectTaskByIdHandler.cs [1,4 KB]
Application/ProjectTasks/Queries/GetById/GetProjectTaskByIdQuery.cs [254 B]
Application/ProjectTasks/Queries/GetPublished/GetPublishedTasksHandler.cs [1,7 KB]
Application/ProjectTasks/Queries/GetPublished/GetPublishedTasksQuery.cs [279 B]
Application/ProjectTasks/Queries/GetResponses/GetTaskResponsesHandler.cs [1,2 KB]
Application/ProjectTasks/Queries/GetResponses/GetTaskResponsesQuery.cs [251 B]
Application/ProjectTasks/Queries/SearchTasks/ISearchTasksQuery.cs [241 B]
Application/ProjectTasks/Queries/SearchTasks/SearchCustomerTasksHandler.cs [1,5 KB]
Application/ProjectTasks/Queries/SearchTasks/SearchCustomerTasksQuery.cs [197 B]
Application/ProjectTasks/Queries/SearchTasks/SearchPublishedTasksHandler.cs [1,6 KB]
Application/ProjectTasks/Queries/SearchTasks/SearchPublishedTasksQuery.cs [201 B]
Application/ProjectTasks/Queries/SearchTasks/SearchTasksQueryFactory.cs [517 B]
Application/Services/FileStorage/FileStorageService.cs [3,0 KB]
Application/Services/FileStorage/IFileStorageService.cs [444 B]
Application/Services/Hasher/IPasswordHasher.cs [218 B]
Application/Services/Hasher/PasswordHasher.cs [1,3 KB]
Application/Services/JwtGenerator/IJwtTokenGenerator.cs [195 B]
Application/Services/JwtGenerator/JwtTokenGenerator.cs [1,7 KB]
Application/UserActions/Queries/GetUserActions/GetUserActionsHandler.cs [2,1 KB]
Application/UserActions/Queries/GetUserActions/GetUserActionsQuery.cs [311 B]
Application/Users/Commands/BlockUser/BlockUserCommand.cs [304 B]
Application/Users/Commands/BlockUser/BlockUserHandler.cs [957 B]
Application/Users/Commands/ChangeRole/ChangeRoleCommand.cs [333 B]
Application/Users/Commands/ChangeRole/ChangeRoleHandler.cs [1,1 KB]
Application/Users/Commands/Delete/DeleteUserCommand.cs [302 B]
Application/Users/Commands/Delete/DeleteUserHandler.cs [959 B]
Application/Users/Commands/Login/LoginUserCommand.cs [234 B]
Application/Users/Commands/Login/LoginUserHandler.cs [1,9 KB]
Application/Users/Commands/Register/RegisterUserCommand.cs [281 B]
Application/Users/Commands/Register/RegisterUserHandler.cs [2,4 KB]
Application/Users/Commands/UnblockUser/UnblockUserCommand.cs [310 B]
Application/Users/Commands/UnblockUser/UnblockUserHandler.cs [969 B]
Application/Users/Commands/Update/UpdateUserCommand.cs [193 B]
Application/Users/Commands/Update/UpdateUserHandler.cs [1,3 KB]
Application/Users/Queries/GetAll/GetAllUsersHandler.cs [902 B]
Application/Users/Queries/GetAll/GetAllUsersQuery.cs [241 B]
Application/Users/Queries/GetById/GetUserByIdHandler.cs [1,0 KB]
Application/Users/Queries/GetById/GetUserByIdQuery.cs [213 B]
Application/Users/Queries/GetUsers/GetUsersHandler.cs [1,2 KB]
Application/Users/Queries/GetUsers/GetUsersQuery.cs [240 B]
Application/Users/Queries/SearchByName/SearchUsersHandler.cs [1,1 KB]
Application/Users/Queries/SearchByName/SearchUsersQuery.cs [272 B]
Blazor Web App/appsettings.Development.json [127 B]
Blazor Web App/appsettings.json [151 B]
Blazor Web App/Blazor Web App.csproj [524 B]
Blazor Web App/Components/App.razor [713 B]
Blazor Web App/Components/Layout/CultureSelector.razor [274 B]
Blazor Web App/Components/Layout/CultureSelector.razor.cs [927 B]
Blazor Web App/Components/Layout/MainLayout.razor [1,1 KB]
Blazor Web App/Components/Layout/MainLayout.razor.cs [153 B]
Blazor Web App/Components/Layout/MainLayout.razor.css [1,9 KB]
Blazor Web App/Components/Layout/NavMenu.razor [3,0 KB]
Blazor Web App/Components/Layout/NavMenu.razor.cs [974 B]
Blazor Web App/Components/Layout/NavMenu.razor.css [3,3 KB]
Blazor Web App/Components/Layout/ReconnectModal.razor [1,3 KB]
Blazor Web App/Components/Layout/ReconnectModal.razor.css [3,8 KB]
Blazor Web App/Components/Layout/ReconnectModal.razor.js [2,4 KB]
Blazor Web App/Components/Pages/Admin/AdminActions.razor [3,9 KB]
Blazor Web App/Components/Pages/Admin/AdminActions.razor.cs [2,3 KB]
Blazor Web App/Components/Pages/Admin/AdminUsers.razor [4,6 KB]
Blazor Web App/Components/Pages/Admin/AdminUsers.razor.cs [3,2 KB]
Blazor Web App/Components/Pages/Auth/Login.razor [1,3 KB]
Blazor Web App/Components/Pages/Auth/Login.razor.cs [2,3 KB]
Blazor Web App/Components/Pages/Auth/RedirectToLogin.razor [29 B]
Blazor Web App/Components/Pages/Auth/RedirectToLogin.razor.cs [458 B]
Blazor Web App/Components/Pages/Auth/Register.razor [1,6 KB]
Blazor Web App/Components/Pages/Auth/Register.razor.cs [2,5 KB]
Blazor Web App/Components/Pages/Errors/Error.razor [1,2 KB]
Blazor Web App/Components/Pages/Errors/NotFound.razor [159 B]
Blazor Web App/Components/Pages/Executor/MyAssignedTasks.razor [2,3 KB]
Blazor Web App/Components/Pages/Executor/MyAssignedTasks.razor.cs [3,9 KB]
Blazor Web App/Components/Pages/Home.razor [5,0 KB]
Blazor Web App/Components/Pages/Home.razor.cs [362 B]
Blazor Web App/Components/Pages/Tasks.razor [4,7 KB]
Blazor Web App/Components/Pages/Tasks.razor.cs [6,9 KB]
Blazor Web App/Components/Pages/TasksModals/AttachmentsModal.razor [4,2 KB]
Blazor Web App/Components/Pages/TasksModals/AttachmentsModal.razor.cs [5,0 KB]
Blazor Web App/Components/Pages/TasksModals/ChatModal.razor [2,9 KB]
Blazor Web App/Components/Pages/TasksModals/ChatModal.razor.cs [5,5 KB]
Blazor Web App/Components/Pages/TasksModals/CreateTaskModal.razor [2,4 KB]
Blazor Web App/Components/Pages/TasksModals/CreateTaskModal.razor.cs [1,8 KB]
Blazor Web App/Components/Pages/TasksModals/EditTaskModal.razor [2,4 KB]
Blazor Web App/Components/Pages/TasksModals/EditTaskModal.razor.cs [2,1 KB]
Blazor Web App/Components/Pages/TasksModals/RateExecutorModal.razor [1,8 KB]
Blazor Web App/Components/Pages/TasksModals/RateExecutorModal.razor.cs [1,8 KB]
Blazor Web App/Components/Pages/TasksModals/ResponsesModal.razor [2,8 KB]
Blazor Web App/Components/Pages/TasksModals/ResponsesModal.razor.cs [2,4 KB]
Blazor Web App/Components/Pages/TasksModals/TaskCard.razor [2,8 KB]
Blazor Web App/Components/Pages/TasksModals/TaskCard.razor.cs [3,3 KB]
Blazor Web App/Components/Routes.razor [612 B]
Blazor Web App/Components/_Imports.razor [978 B]
Blazor Web App/Constants/AttachmentConstants.cs [121 B]
Blazor Web App/Constants/CultureConstants.cs [374 B]
Blazor Web App/Constants/FormatConstants.cs [232 B]
Blazor Web App/Constants/Pagination.cs [159 B]
Blazor Web App/Constants/ServiceMessages.cs [372 B]
Blazor Web App/Extensions/ServiceCollectionExtensions.cs [3,4 KB]
Blazor Web App/Modals/ModalState.cs [441 B]
Blazor Web App/Program.cs [862 B]
Blazor Web App/Properties/launchSettings.json [681 B]
Blazor Web App/Resources/ResourceKeys.cs [5,2 KB]
Blazor Web App/Resources/SharedResources.cs [78 B]
Blazor Web App/Resources/SharedResources.resx [11,8 KB]
Blazor Web App/Resources/SharedResources.ru-RU.resx [13,1 KB]
Blazor Web App/Services/Culture/CultureService.cs [1,2 KB]
Blazor Web App/Services/Culture/ICultureService.cs [206 B]
Blazor Web App/Services/CustomAuthStateProvider.cs [2,3 KB]
Blazor Web App/Services/LocalStorage/ILocalStorageService.cs [237 B]
Blazor Web App/Services/LocalStorage/LocalStorageService.cs [873 B]
Blazor Web App/Services/Receivers/Auth/AuthService.cs [1,3 KB]
Blazor Web App/Services/Receivers/Auth/IAuthService.cs [423 B]
Blazor Web App/Services/Receivers/BaseService.cs [2,7 KB]
Blazor Web App/Services/Receivers/Chats/ChatService.cs [1,8 KB]
Blazor Web App/Services/Receivers/Chats/IChatService.cs [501 B]
Blazor Web App/Services/Receivers/ProjectTasks/IProjectTaskService.cs [2,0 KB]
Blazor Web App/Services/Receivers/ProjectTasks/ProjectTaskService.cs [7,3 KB]
Blazor Web App/Services/Receivers/TaskAttachments/ITaskAttachmentService.cs [758 B]
Blazor Web App/Services/Receivers/TaskAttachments/TaskAttachmentService.cs [2,8 KB]
Blazor Web App/Services/Receivers/UserActions/IUserActionService.cs [432 B]
Blazor Web App/Services/Receivers/UserActions/UserActionService.cs [1,2 KB]
Blazor Web App/Services/Receivers/Users/IUserService.cs [798 B]
Blazor Web App/Services/Receivers/Users/UserService.cs [2,8 KB]
Blazor Web App/Settings/ApiSettings.cs [327 B]
Blazor Web App/wwwroot/app.css [2,8 KB]
Blazor Web App/wwwroot/download.js [456 B]
blazor.dockerfile [434 B]
docker-compose.yml [1,6 KB]
Domain/Config/AppConfig.cs [459 B]
Domain/Config/FileStorage.cs [397 B]
Domain/Config/IConfigSection.cs [119 B]
Domain/Config/JwtSettings.cs [716 B]
Domain/Constants/AttachmentConstants.cs [253 B]
Domain/Constants/CurrencyConstants.cs [242 B]
Domain/Constants/ErrorMessages.cs [4,4 KB]
Domain/Constants/LoggerMessages.cs [296 B]
Domain/Constants/RatingConstants.cs [227 B]
Domain/Domain.csproj [312 B]
Domain/Entities/Chat.cs [1,0 KB]
Domain/Entities/Entity.cs [451 B]
Domain/Entities/Message.cs [576 B]
Domain/Entities/ProjectTask.cs [6,4 KB]
Domain/Entities/TaskAttachment.cs [3,0 KB]
Domain/Entities/TaskResponse.cs [637 B]
Domain/Entities/User.cs [2,2 KB]
Domain/Entities/UserAction.cs [859 B]
Domain/Interfaces/Chats/IChatCommandRepository.cs [356 B]
Domain/Interfaces/Chats/IChatQueryRepository.cs [601 B]
Domain/Interfaces/Files/ITaskAttachmentCommandRepository.cs [218 B]
Domain/Interfaces/Files/ITaskAttachmentQueryRepository.cs [448 B]
Domain/Interfaces/IUnitOfWork.cs [151 B]
Domain/Interfaces/ProjectTasks/IProjectTaskCommandRepository.cs [405 B]
Domain/Interfaces/ProjectTasks/IProjectTaskQueryRepository.cs [1,5 KB]
Domain/Interfaces/UserActions/IUserActionCommandRepository.cs [212 B]
Domain/Interfaces/UserActions/IUserActionQueryRepository.cs [345 B]
Domain/Interfaces/Users/IUserCommandRepository.cs [356 B]
Domain/Interfaces/Users/IUserQueryRepository.cs [917 B]
Infrastructure/AppDbContext.cs [2,9 KB]
Infrastructure/Infrastructure.csproj [690 B]
Infrastructure/Migrations/20260927160150_InitialCreate.cs [4,5 KB]
Infrastructure/Migrations/20260927160150_InitialCreate.Designer.cs [5,1 KB]
Infrastructure/Migrations/20260930073322_AddPasswordHash.cs [802 B]
Infrastructure/Migrations/20260930073322_AddPasswordHash.Designer.cs [5,3 KB]
Infrastructure/Migrations/20261001100840_AddSentAtToMessage.cs [929 B]
Infrastructure/Migrations/20261001100840_AddSentAtToMessage.Designer.cs [5,4 KB]
Infrastructure/Migrations/20261001201155_AddedResponseTaskEntity.cs [1,9 KB]
Infrastructure/Migrations/20261001201155_AddedResponseTaskEntity.Designer.cs [6,8 KB]
Infrastructure/Migrations/20261001210320_FixRelationsBetweenReponseAndTask.cs [2,3 KB]
Infrastructure/Migrations/20261001210320_FixRelationsBetweenReponseAndTask.Designer.cs [6,8 KB]
Infrastructure/Migrations/20261001215958_FixRelations.cs [2,6 KB]
Infrastructure/Migrations/20261001215958_FixRelations.Designer.cs [6,7 KB]
Infrastructure/Migrations/20261002165145_AddUserActions.cs [1,5 KB]
Infrastructure/Migrations/20261002165145_AddUserActions.Designer.cs [7,6 KB]
Infrastructure/Migrations/20261002174150_AddUserBlocked.cs [2,3 KB]
Infrastructure/Migrations/20261002174150_AddUserBlocked.Designer.cs [7,8 KB]
Infrastructure/Migrations/20261006095229_AttacmentEntity.cs [2,7 KB]
Infrastructure/Migrations/20261006095229_AttacmentEntity.Designer.cs [10,0 KB]
Infrastructure/Migrations/20261015152600_AddIndexToChat.cs [778 B]
Infrastructure/Migrations/20261015152600_AddIndexToChat.Designer.cs [10,1 KB]
Infrastructure/Migrations/AppDbContextModelSnapshot.cs [10,0 KB]
Infrastructure/Repositories/Chats/ChatCommandRepository.cs [1,0 KB]
Infrastructure/Repositories/Chats/ChatQueryRepository.cs [2,0 KB]
Infrastructure/Repositories/Files/TaskAttachmentCommandRepository.cs [572 B]
Infrastructure/Repositories/Files/TaskAttachmentQueryRepository.cs [1,3 KB]
Infrastructure/Repositories/ProjectTasks/ProjectTaskCommandRepository.cs [1,2 KB]
Infrastructure/Repositories/ProjectTasks/ProjectTaskQueryRepository.cs [7,7 KB]
Infrastructure/Repositories/UnitOfWork.cs [429 B]
Infrastructure/Repositories/UserActions/UserActionCommandRepository.cs [556 B]
Infrastructure/Repositories/UserActions/UserActionQueryRepository.cs [1,5 KB]
Infrastructure/Repositories/Users/UserCommandRepository.cs [1,0 KB]
Infrastructure/Repositories/Users/UserQueryRepository.cs [3,8 KB]
README.md [1,3 KB]
Shared/Dtos/Requests/Chats/AddMessageChatDto.cs [103 B]
Shared/Dtos/Requests/PageDto.cs [103 B]
Shared/Dtos/Requests/ProjectTasks/AssignProjectTaskDto.cs [117 B]
Shared/Dtos/Requests/ProjectTasks/CreateProjectTaskDto.cs [351 B]
Shared/Dtos/Requests/ProjectTasks/UpdateProjectTaskDto.cs [217 B]
Shared/Dtos/Requests/Users/ChangeRoleUserDto.cs [129 B]
Shared/Dtos/Requests/Users/LoginDto.cs [110 B]
Shared/Dtos/Requests/Users/RegisterDto.cs [160 B]
Shared/Dtos/Requests/Users/UpdateUserDto.cs [99 B]
Shared/Dtos/Responses/Chats/ChatDto.cs [447 B]
Shared/Dtos/Responses/Chats/MessageDto.cs [619 B]
Shared/Dtos/Responses/PagedResult.cs [1,3 KB]
Shared/Dtos/Responses/ProjectTasks/AttachmentFileResult.cs [274 B]
Shared/Dtos/Responses/ProjectTasks/MarkAsDoneProjectTaskDto.cs [119 B]
Shared/Dtos/Responses/ProjectTasks/ProjectTaskDto.cs [1,5 KB]
Shared/Dtos/Responses/ProjectTasks/TaskAttachmentDto.cs [947 B]
Shared/Dtos/Responses/ProjectTasks/TaskResponseDto.cs [302 B]
Shared/Dtos/Responses/Result.cs [1,4 KB]
Shared/Dtos/Responses/UserActions/UserActionDto.cs [408 B]
Shared/Dtos/Responses/Users/AuthDto.cs [533 B]
Shared/Dtos/Responses/Users/UserDto.cs [192 B]
Shared/Enums/ErrorType.cs [154 B]
Shared/Enums/ProjectTaskStatus.cs [127 B]
Shared/Enums/UserAction.cs [365 B]
Shared/Enums/UserRole.cs [97 B]
Shared/Shared.csproj [219 B]
Task Marketplace.slnx [462 B]
TgBot/Program.cs [40 B]
TgBot/TgBot.csproj [253 B]
Web Api/appsettings.json [385 B]
Web Api/Controllers/AuthController.cs [1,3 KB]
Web Api/Controllers/ChatController.cs [2,9 KB]
Web Api/Controllers/ProjectTaskController.cs [7,0 KB]
Web Api/Controllers/TaskAttachmentsController.cs [2,5 KB]
Web Api/Controllers/UserActionController.cs [1,0 KB]
Web Api/Controllers/UserController.cs [2,4 KB]
Web Api/ExceptionHandler/GlobalExceptionHandler.cs [1,2 KB]
Web Api/Extensions/Constants/SwaggerConstants.cs [469 B]
Web Api/Extensions/CurrentUser.cs [742 B]
Web Api/Extensions/ResultExtensions.cs [1,8 KB]
Web Api/Extensions/ServiceCollectionExtensions.cs [6,4 KB]
Web Api/Program.cs [1,1 KB]
Web Api/Properties/launchSettings.json [644 B]
Web Api/Web Api.csproj [1,2 KB]
Web/appsettings.Development.json [154 B]
Web/appsettings.json [151 B]
Web/Pages/Error.cshtml [882 B]
Web/Pages/Error.cshtml.cs [516 B]
Web/Pages/Index.cshtml [266 B]
Web/Pages/Index.cshtml.cs [187 B]
Web/Pages/Privacy.cshtml [172 B]
Web/Pages/Privacy.cshtml.cs [192 B]
Web/Pages/Shared/_Layout.cshtml [2,2 KB]
Web/Pages/Shared/_Layout.cshtml.css [925 B]
Web/Pages/Shared/_ValidationScriptsPartial.cshtml [181 B]
Web/Pages/_ViewImports.cshtml [91 B]
Web/Pages/_ViewStart.cshtml [35 B]
Web/Program.cs [598 B]
Web/Properties/launchSettings.json [639 B]
Web/Web.csproj [220 B]
Web/wwwroot/css/site.css [667 B]
Web/wwwroot/js/site.js [231 B]
Web/wwwroot/lib/bootstrap/LICENSE [1,1 KB]
Web/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt [1,1 KB]
Web/wwwroot/lib/jquery-validation/LICENSE.md [1,1 KB]
Web/wwwroot/lib/jquery/LICENSE.txt [1,1 KB]
wep-api.dockerfile [758 B]
```

## Directory Tree

```text
Task Marketplace/
├── .git [IGNORED DIR]/
├── .vs [IGNORED DIR]/
├── Application/
│   ├── Attachments/
│   │   ├── Commands/
│   │   │   ├── DeleteAttachment/
│   │   │   │   ├── DeleteAttachmentCommand.cs [197 B]
│   │   │   │   └── DeleteAttachmentHandler.cs [1,8 KB]
│   │   │   └── UploadAttachment/
│   │   │       ├── UploadAttachmentCommand.cs [337 B]
│   │   │       └── UploadAttachmentHandler.cs [3,2 KB]
│   │   └── Queries/
│   │       ├── GetAttachmentFile/
│   │       │   ├── GetAttachmentFileHandler.cs [2,1 KB]
│   │       │   └── GetAttachmentFileQuery.cs [263 B]
│   │       └── GetTaskAttachments/
│   │           ├── GetTaskAttachmentsHandler.cs [1,0 KB]
│   │           └── GetTaskAttachmentsQuery.cs [243 B]
│   ├── Behaviors/
│   │   ├── TransactionBehaviour.cs [962 B]
│   │   └── UserActionLoggingBehavior.cs [1,4 KB]
│   ├── bin [IGNORED DIR]/
│   ├── Chats/
│   │   ├── Commands/
│   │   │   ├── AddMessage/
│   │   │   │   ├── AddMessageCommand.cs [318 B]
│   │   │   │   └── AddMessageHandler.cs [2,4 KB]
│   │   │   ├── Create/
│   │   │   │   ├── CreateChatCommand.cs [348 B]
│   │   │   │   └── CreateChatHandler.cs [2,3 KB]
│   │   │   └── Delete/
│   │   │       ├── DeleteChatCommand.cs [296 B]
│   │   │       └── DeleteChatHandler.cs [1,9 KB]
│   │   └── Queries/
│   │       ├── GetById/
│   │       │   ├── GetChatByIdHandler.cs [1,2 KB]
│   │       │   └── GetChatByIdQuery.cs [215 B]
│   │       ├── GetByTaskId/
│   │       │   ├── GetChatByTaskIdHandler.cs [2,2 KB]
│   │       │   └── GetChatByTaskIdQuery.cs [221 B]
│   │       └── GetWithMessages/
│   │           ├── GetChatWithMessagesHandler.cs [1,2 KB]
│   │           └── GetChatWithMessagesQuery.cs [229 B]
│   ├── Common/
│   │   └── LogActionAttribute.cs [423 B]
│   ├── Interfaces/
│   │   └── ICurrentUser.cs [130 B]
│   ├── Mappers/
│   │   ├── ChatMapper.cs [627 B]
│   │   ├── ProjectTaskMapper.cs [1,6 KB]
│   │   ├── TaskAttachmentMapper.cs [670 B]
│   │   └── UserMapper.cs [767 B]
│   ├── obj [IGNORED DIR]/
│   ├── ProjectTasks/
│   │   ├── Commands/
│   │   │   ├── AssignExecutor/
│   │   │   │   ├── AssignExecutorCommand.cs [349 B]
│   │   │   │   └── AssignExecutorHandler.cs [1,4 KB]
│   │   │   ├── Cancel/
│   │   │   │   ├── CancelProjectTaskCommand.cs [319 B]
│   │   │   │   └── CancelProjectTaskHandler.cs [1,3 KB]
│   │   │   ├── Create/
│   │   │   │   ├── CreateProjectTaskCommand.cs [486 B]
│   │   │   │   └── CreateProjectTaskHandler.cs [1,7 KB]
│   │   │   ├── Delete/
│   │   │   │   ├── DeleteProjectTaskCommand.cs [317 B]
│   │   │   │   └── DeleteProjectTaskHandler.cs [1,3 KB]
│   │   │   ├── MarkAsDone/
│   │   │   │   ├── MarkAsDoneCommand.cs [339 B]
│   │   │   │   └── MarkAsDoneHandler.cs [2,1 KB]
│   │   │   ├── RespondToTask/
│   │   │   │   ├── RespondToTaskCommand.cs [324 B]
│   │   │   │   └── RespondToTaskHandler.cs [1,3 KB]
│   │   │   └── Update/
│   │   │       ├── UpdateProjectTaskCommand.cs [445 B]
│   │   │       └── UpdateProjectTaskHandler.cs [1,5 KB]
│   │   └── Queries/
│   │       ├── GetAssigned/
│   │       │   ├── GetAssignedTasksHandler.cs [1,3 KB]
│   │       │   └── GetAssignedTasksQuery.cs [296 B]
│   │       ├── GetByCustomer/
│   │       │   ├── GetTasksByCustomerHandler.cs [1,2 KB]
│   │       │   └── GetTasksByCustomerQuery.cs [305 B]
│   │       ├── GetById/
│   │       │   ├── GetProjectTaskByIdHandler.cs [1,4 KB]
│   │       │   └── GetProjectTaskByIdQuery.cs [254 B]
│   │       ├── GetPublished/
│   │       │   ├── GetPublishedTasksHandler.cs [1,7 KB]
│   │       │   └── GetPublishedTasksQuery.cs [279 B]
│   │       ├── GetResponses/
│   │       │   ├── GetTaskResponsesHandler.cs [1,2 KB]
│   │       │   └── GetTaskResponsesQuery.cs [251 B]
│   │       └── SearchTasks/
│   │           ├── ISearchTasksQuery.cs [241 B]
│   │           ├── SearchCustomerTasksHandler.cs [1,5 KB]
│   │           ├── SearchCustomerTasksQuery.cs [197 B]
│   │           ├── SearchPublishedTasksHandler.cs [1,6 KB]
│   │           ├── SearchPublishedTasksQuery.cs [201 B]
│   │           └── SearchTasksQueryFactory.cs [517 B]
│   ├── Services/
│   │   ├── FileStorage/
│   │   │   ├── FileStorageService.cs [3,0 KB]
│   │   │   └── IFileStorageService.cs [444 B]
│   │   ├── Hasher/
│   │   │   ├── IPasswordHasher.cs [218 B]
│   │   │   └── PasswordHasher.cs [1,3 KB]
│   │   └── JwtGenerator/
│   │       ├── IJwtTokenGenerator.cs [195 B]
│   │       └── JwtTokenGenerator.cs [1,7 KB]
│   ├── UserActions/
│   │   └── Queries/
│   │       └── GetUserActions/
│   │           ├── GetUserActionsHandler.cs [2,1 KB]
│   │           └── GetUserActionsQuery.cs [311 B]
│   ├── Users/
│   │   ├── Commands/
│   │   │   ├── BlockUser/
│   │   │   │   ├── BlockUserCommand.cs [304 B]
│   │   │   │   └── BlockUserHandler.cs [957 B]
│   │   │   ├── ChangeRole/
│   │   │   │   ├── ChangeRoleCommand.cs [333 B]
│   │   │   │   └── ChangeRoleHandler.cs [1,1 KB]
│   │   │   ├── Delete/
│   │   │   │   ├── DeleteUserCommand.cs [302 B]
│   │   │   │   └── DeleteUserHandler.cs [959 B]
│   │   │   ├── Login/
│   │   │   │   ├── LoginUserCommand.cs [234 B]
│   │   │   │   └── LoginUserHandler.cs [1,9 KB]
│   │   │   ├── Register/
│   │   │   │   ├── RegisterUserCommand.cs [281 B]
│   │   │   │   └── RegisterUserHandler.cs [2,4 KB]
│   │   │   ├── UnblockUser/
│   │   │   │   ├── UnblockUserCommand.cs [310 B]
│   │   │   │   └── UnblockUserHandler.cs [969 B]
│   │   │   └── Update/
│   │   │       ├── UpdateUserCommand.cs [193 B]
│   │   │       └── UpdateUserHandler.cs [1,3 KB]
│   │   └── Queries/
│   │       ├── GetAll/
│   │       │   ├── GetAllUsersHandler.cs [902 B]
│   │       │   └── GetAllUsersQuery.cs [241 B]
│   │       ├── GetById/
│   │       │   ├── GetUserByIdHandler.cs [1,0 KB]
│   │       │   └── GetUserByIdQuery.cs [213 B]
│   │       ├── GetUsers/
│   │       │   ├── GetUsersHandler.cs [1,2 KB]
│   │       │   └── GetUsersQuery.cs [240 B]
│   │       └── SearchByName/
│   │           ├── SearchUsersHandler.cs [1,1 KB]
│   │           └── SearchUsersQuery.cs [272 B]
│   └── Application.csproj [702 B]
├── Blazor Web App/
│   ├── bin [IGNORED DIR]/
│   ├── Components/
│   │   ├── Layout/
│   │   │   ├── CultureSelector.razor [274 B]
│   │   │   ├── CultureSelector.razor.cs [927 B]
│   │   │   ├── MainLayout.razor [1,1 KB]
│   │   │   ├── MainLayout.razor.cs [153 B]
│   │   │   ├── MainLayout.razor.css [1,9 KB]
│   │   │   ├── NavMenu.razor [3,0 KB]
│   │   │   ├── NavMenu.razor.cs [974 B]
│   │   │   ├── NavMenu.razor.css [3,3 KB]
│   │   │   ├── ReconnectModal.razor [1,3 KB]
│   │   │   ├── ReconnectModal.razor.css [3,8 KB]
│   │   │   └── ReconnectModal.razor.js [2,4 KB]
│   │   ├── Pages/
│   │   │   ├── Admin/
│   │   │   │   ├── AdminActions.razor [3,9 KB]
│   │   │   │   ├── AdminActions.razor.cs [2,3 KB]
│   │   │   │   ├── AdminUsers.razor [4,6 KB]
│   │   │   │   └── AdminUsers.razor.cs [3,2 KB]
│   │   │   ├── Auth/
│   │   │   │   ├── Login.razor [1,3 KB]
│   │   │   │   ├── Login.razor.cs [2,3 KB]
│   │   │   │   ├── RedirectToLogin.razor [29 B]
│   │   │   │   ├── RedirectToLogin.razor.cs [458 B]
│   │   │   │   ├── Register.razor [1,6 KB]
│   │   │   │   └── Register.razor.cs [2,5 KB]
│   │   │   ├── Errors/
│   │   │   │   ├── Error.razor [1,2 KB]
│   │   │   │   └── NotFound.razor [159 B]
│   │   │   ├── Executor/
│   │   │   │   ├── MyAssignedTasks.razor [2,3 KB]
│   │   │   │   └── MyAssignedTasks.razor.cs [3,9 KB]
│   │   │   ├── TasksModals/
│   │   │   │   ├── AttachmentsModal.razor [4,2 KB]
│   │   │   │   ├── AttachmentsModal.razor.cs [5,0 KB]
│   │   │   │   ├── ChatModal.razor [2,9 KB]
│   │   │   │   ├── ChatModal.razor.cs [5,5 KB]
│   │   │   │   ├── CreateTaskModal.razor [2,4 KB]
│   │   │   │   ├── CreateTaskModal.razor.cs [1,8 KB]
│   │   │   │   ├── EditTaskModal.razor [2,4 KB]
│   │   │   │   ├── EditTaskModal.razor.cs [2,1 KB]
│   │   │   │   ├── RateExecutorModal.razor [1,8 KB]
│   │   │   │   ├── RateExecutorModal.razor.cs [1,8 KB]
│   │   │   │   ├── ResponsesModal.razor [2,8 KB]
│   │   │   │   ├── ResponsesModal.razor.cs [2,4 KB]
│   │   │   │   ├── TaskCard.razor [2,8 KB]
│   │   │   │   └── TaskCard.razor.cs [3,3 KB]
│   │   │   ├── Home.razor [5,0 KB]
│   │   │   ├── Home.razor.cs [362 B]
│   │   │   ├── Tasks.razor [4,7 KB]
│   │   │   └── Tasks.razor.cs [6,9 KB]
│   │   ├── App.razor [713 B]
│   │   ├── Routes.razor [612 B]
│   │   └── _Imports.razor [978 B]
│   ├── Constants/
│   │   ├── AttachmentConstants.cs [121 B]
│   │   ├── CultureConstants.cs [374 B]
│   │   ├── FormatConstants.cs [232 B]
│   │   ├── Pagination.cs [159 B]
│   │   └── ServiceMessages.cs [372 B]
│   ├── Extensions/
│   │   └── ServiceCollectionExtensions.cs [3,4 KB]
│   ├── Modals/
│   │   └── ModalState.cs [441 B]
│   ├── obj [IGNORED DIR]/
│   ├── Properties/
│   │   └── launchSettings.json [681 B]
│   ├── Resources/
│   │   ├── ResourceKeys.cs [5,2 KB]
│   │   ├── SharedResources.cs [78 B]
│   │   ├── SharedResources.resx [11,8 KB]
│   │   └── SharedResources.ru-RU.resx [13,1 KB]
│   ├── Services/
│   │   ├── Culture/
│   │   │   ├── CultureService.cs [1,2 KB]
│   │   │   └── ICultureService.cs [206 B]
│   │   ├── LocalStorage/
│   │   │   ├── ILocalStorageService.cs [237 B]
│   │   │   └── LocalStorageService.cs [873 B]
│   │   ├── Receivers/
│   │   │   ├── Auth/
│   │   │   │   ├── AuthService.cs [1,3 KB]
│   │   │   │   └── IAuthService.cs [423 B]
│   │   │   ├── Chats/
│   │   │   │   ├── ChatService.cs [1,8 KB]
│   │   │   │   └── IChatService.cs [501 B]
│   │   │   ├── ProjectTasks/
│   │   │   │   ├── IProjectTaskService.cs [2,0 KB]
│   │   │   │   └── ProjectTaskService.cs [7,3 KB]
│   │   │   ├── TaskAttachments/
│   │   │   │   ├── ITaskAttachmentService.cs [758 B]
│   │   │   │   └── TaskAttachmentService.cs [2,8 KB]
│   │   │   ├── UserActions/
│   │   │   │   ├── IUserActionService.cs [432 B]
│   │   │   │   └── UserActionService.cs [1,2 KB]
│   │   │   ├── Users/
│   │   │   │   ├── IUserService.cs [798 B]
│   │   │   │   └── UserService.cs [2,8 KB]
│   │   │   └── BaseService.cs [2,7 KB]
│   │   └── CustomAuthStateProvider.cs [2,3 KB]
│   ├── Settings/
│   │   └── ApiSettings.cs [327 B]
│   ├── wwwroot/
│   │   ├── lib/
│   │   │   └── bootstrap/
│   │   │       └── dist [IGNORED DIR]/
│   │   ├── app.css [2,8 KB]
│   │   ├── download.js [456 B]
│   │   └── favicon.png [IGNORED FILE]
│   ├── appsettings.Development.json [127 B]
│   ├── appsettings.json [151 B]
│   ├── Blazor Web App.csproj [524 B]
│   ├── Blazor Web App.csproj.user [IGNORED FILE]
│   └── Program.cs [862 B]
├── Domain/
│   ├── bin [IGNORED DIR]/
│   ├── Config/
│   │   ├── AppConfig.cs [459 B]
│   │   ├── FileStorage.cs [397 B]
│   │   ├── IConfigSection.cs [119 B]
│   │   └── JwtSettings.cs [716 B]
│   ├── Constants/
│   │   ├── AttachmentConstants.cs [253 B]
│   │   ├── CurrencyConstants.cs [242 B]
│   │   ├── ErrorMessages.cs [4,4 KB]
│   │   ├── LoggerMessages.cs [296 B]
│   │   └── RatingConstants.cs [227 B]
│   ├── Entities/
│   │   ├── Chat.cs [1,0 KB]
│   │   ├── Entity.cs [451 B]
│   │   ├── Message.cs [576 B]
│   │   ├── ProjectTask.cs [6,4 KB]
│   │   ├── TaskAttachment.cs [3,0 KB]
│   │   ├── TaskResponse.cs [637 B]
│   │   ├── User.cs [2,2 KB]
│   │   └── UserAction.cs [859 B]
│   ├── Interfaces/
│   │   ├── Chats/
│   │   │   ├── IChatCommandRepository.cs [356 B]
│   │   │   └── IChatQueryRepository.cs [601 B]
│   │   ├── Files/
│   │   │   ├── ITaskAttachmentCommandRepository.cs [218 B]
│   │   │   └── ITaskAttachmentQueryRepository.cs [448 B]
│   │   ├── ProjectTasks/
│   │   │   ├── IProjectTaskCommandRepository.cs [405 B]
│   │   │   └── IProjectTaskQueryRepository.cs [1,5 KB]
│   │   ├── UserActions/
│   │   │   ├── IUserActionCommandRepository.cs [212 B]
│   │   │   └── IUserActionQueryRepository.cs [345 B]
│   │   ├── Users/
│   │   │   ├── IUserCommandRepository.cs [356 B]
│   │   │   └── IUserQueryRepository.cs [917 B]
│   │   └── IUnitOfWork.cs [151 B]
│   ├── obj [IGNORED DIR]/
│   └── Domain.csproj [312 B]
├── Infrastructure/
│   ├── bin [IGNORED DIR]/
│   ├── Migrations/
│   │   ├── 20260927160150_InitialCreate.cs [4,5 KB]
│   │   ├── 20260927160150_InitialCreate.Designer.cs [5,1 KB]
│   │   ├── 20260930073322_AddPasswordHash.cs [802 B]
│   │   ├── 20260930073322_AddPasswordHash.Designer.cs [5,3 KB]
│   │   ├── 20261001100840_AddSentAtToMessage.cs [929 B]
│   │   ├── 20261001100840_AddSentAtToMessage.Designer.cs [5,4 KB]
│   │   ├── 20261001201155_AddedResponseTaskEntity.cs [1,9 KB]
│   │   ├── 20261001201155_AddedResponseTaskEntity.Designer.cs [6,8 KB]
│   │   ├── 20261001210320_FixRelationsBetweenReponseAndTask.cs [2,3 KB]
│   │   ├── 20261001210320_FixRelationsBetweenReponseAndTask.Designer.cs [6,8 KB]
│   │   ├── 20261001215958_FixRelations.cs [2,6 KB]
│   │   ├── 20261001215958_FixRelations.Designer.cs [6,7 KB]
│   │   ├── 20261002165145_AddUserActions.cs [1,5 KB]
│   │   ├── 20261002165145_AddUserActions.Designer.cs [7,6 KB]
│   │   ├── 20261002174150_AddUserBlocked.cs [2,3 KB]
│   │   ├── 20261002174150_AddUserBlocked.Designer.cs [7,8 KB]
│   │   ├── 20261006095229_AttacmentEntity.cs [2,7 KB]
│   │   ├── 20261006095229_AttacmentEntity.Designer.cs [10,0 KB]
│   │   ├── 20261015152600_AddIndexToChat.cs [778 B]
│   │   ├── 20261015152600_AddIndexToChat.Designer.cs [10,1 KB]
│   │   └── AppDbContextModelSnapshot.cs [10,0 KB]
│   ├── obj [IGNORED DIR]/
│   ├── Repositories/
│   │   ├── Chats/
│   │   │   ├── ChatCommandRepository.cs [1,0 KB]
│   │   │   └── ChatQueryRepository.cs [2,0 KB]
│   │   ├── Files/
│   │   │   ├── TaskAttachmentCommandRepository.cs [572 B]
│   │   │   └── TaskAttachmentQueryRepository.cs [1,3 KB]
│   │   ├── ProjectTasks/
│   │   │   ├── ProjectTaskCommandRepository.cs [1,2 KB]
│   │   │   └── ProjectTaskQueryRepository.cs [7,7 KB]
│   │   ├── UserActions/
│   │   │   ├── UserActionCommandRepository.cs [556 B]
│   │   │   └── UserActionQueryRepository.cs [1,5 KB]
│   │   ├── Users/
│   │   │   ├── UserCommandRepository.cs [1,0 KB]
│   │   │   └── UserQueryRepository.cs [3,8 KB]
│   │   └── UnitOfWork.cs [429 B]
│   ├── AppDbContext.cs [2,9 KB]
│   ├── Infrastructure.csproj [690 B]
│   └── Infrastructure.csproj.user [IGNORED FILE]
├── Shared/
│   ├── bin [IGNORED DIR]/
│   ├── Dtos/
│   │   ├── Requests/
│   │   │   ├── Chats/
│   │   │   │   └── AddMessageChatDto.cs [103 B]
│   │   │   ├── ProjectTasks/
│   │   │   │   ├── AssignProjectTaskDto.cs [117 B]
│   │   │   │   ├── CreateProjectTaskDto.cs [351 B]
│   │   │   │   └── UpdateProjectTaskDto.cs [217 B]
│   │   │   ├── Users/
│   │   │   │   ├── ChangeRoleUserDto.cs [129 B]
│   │   │   │   ├── LoginDto.cs [110 B]
│   │   │   │   ├── RegisterDto.cs [160 B]
│   │   │   │   └── UpdateUserDto.cs [99 B]
│   │   │   └── PageDto.cs [103 B]
│   │   └── Responses/
│   │       ├── Chats/
│   │       │   ├── ChatDto.cs [447 B]
│   │       │   └── MessageDto.cs [619 B]
│   │       ├── ProjectTasks/
│   │       │   ├── AttachmentFileResult.cs [274 B]
│   │       │   ├── MarkAsDoneProjectTaskDto.cs [119 B]
│   │       │   ├── ProjectTaskDto.cs [1,5 KB]
│   │       │   ├── TaskAttachmentDto.cs [947 B]
│   │       │   └── TaskResponseDto.cs [302 B]
│   │       ├── UserActions/
│   │       │   └── UserActionDto.cs [408 B]
│   │       ├── Users/
│   │       │   ├── AuthDto.cs [533 B]
│   │       │   └── UserDto.cs [192 B]
│   │       ├── PagedResult.cs [1,3 KB]
│   │       └── Result.cs [1,4 KB]
│   ├── Enums/
│   │   ├── ErrorType.cs [154 B]
│   │   ├── ProjectTaskStatus.cs [127 B]
│   │   ├── UserAction.cs [365 B]
│   │   └── UserRole.cs [97 B]
│   ├── obj [IGNORED DIR]/
│   └── Shared.csproj [219 B]
├── TgBot/
│   ├── Program.cs [40 B]
│   └── TgBot.csproj [253 B]
├── Web/
│   ├── Pages/
│   │   ├── Shared/
│   │   │   ├── _Layout.cshtml [2,2 KB]
│   │   │   ├── _Layout.cshtml.css [925 B]
│   │   │   └── _ValidationScriptsPartial.cshtml [181 B]
│   │   ├── Error.cshtml [882 B]
│   │   ├── Error.cshtml.cs [516 B]
│   │   ├── Index.cshtml [266 B]
│   │   ├── Index.cshtml.cs [187 B]
│   │   ├── Privacy.cshtml [172 B]
│   │   ├── Privacy.cshtml.cs [192 B]
│   │   ├── _ViewImports.cshtml [91 B]
│   │   └── _ViewStart.cshtml [35 B]
│   ├── Properties/
│   │   └── launchSettings.json [639 B]
│   ├── wwwroot/
│   │   ├── css/
│   │   │   └── site.css [667 B]
│   │   ├── js/
│   │   │   └── site.js [231 B]
│   │   ├── lib/
│   │   │   ├── bootstrap/
│   │   │   │   ├── dist [IGNORED DIR]/
│   │   │   │   └── LICENSE [1,1 KB]
│   │   │   ├── jquery/
│   │   │   │   ├── dist [IGNORED DIR]/
│   │   │   │   └── LICENSE.txt [1,1 KB]
│   │   │   ├── jquery-validation/
│   │   │   │   ├── dist [IGNORED DIR]/
│   │   │   │   └── LICENSE.md [1,1 KB]
│   │   │   └── jquery-validation-unobtrusive/
│   │   │       ├── dist [IGNORED DIR]/
│   │   │       └── LICENSE.txt [1,1 KB]
│   │   └── favicon.ico [IGNORED FILE]
│   ├── appsettings.Development.json [154 B]
│   ├── appsettings.json [151 B]
│   ├── Program.cs [598 B]
│   ├── Web.csproj [220 B]
│   └── Web.csproj.user [IGNORED FILE]
├── Web Api/
│   ├── bin [IGNORED DIR]/
│   ├── Controllers/
│   │   ├── AuthController.cs [1,3 KB]
│   │   ├── ChatController.cs [2,9 KB]
│   │   ├── ProjectTaskController.cs [7,0 KB]
│   │   ├── TaskAttachmentsController.cs [2,5 KB]
│   │   ├── UserActionController.cs [1,0 KB]
│   │   └── UserController.cs [2,4 KB]
│   ├── ExceptionHandler/
│   │   └── GlobalExceptionHandler.cs [1,2 KB]
│   ├── Extensions/
│   │   ├── Constants/
│   │   │   └── SwaggerConstants.cs [469 B]
│   │   ├── CurrentUser.cs [742 B]
│   │   ├── ResultExtensions.cs [1,8 KB]
│   │   └── ServiceCollectionExtensions.cs [6,4 KB]
│   ├── obj [IGNORED DIR]/
│   ├── Properties/
│   │   └── launchSettings.json [644 B]
│   ├── appsettings.json [385 B]
│   ├── Program.cs [1,1 KB]
│   ├── Web Api.csproj [1,2 KB]
│   └── Web Api.csproj.user [IGNORED FILE]
├── .editconfig [9,6 KB]
├── .env [IGNORED FILE]
├── .env-example [310 B]
├── .gitignore [7,8 KB]
├── blazor.dockerfile [434 B]
├── docker-compose.yml [1,6 KB]
├── README.md [1,3 KB]
├── Task Marketplace.slnx [462 B]
└── wep-api.dockerfile [758 B]
```

---

## FILE: `.editconfig`

````text
# Remove the line below if you want to inherit .editorconfig settings from higher directories
root = true

# C# files
[*.cs]

#### Core EditorConfig Options ####

# Indentation and spacing
indent_size = 4
indent_style = space
tab_width = 4

# New line preferences
end_of_line = crlf
insert_final_newline = false

#### .NET Coding Conventions ####

# Organize usings
dotnet_separate_import_directive_groups = false
dotnet_sort_system_directives_first = false
file_header_template = unset

# this. and Me. preferences
dotnet_style_qualification_for_event = false
dotnet_style_qualification_for_field = false
dotnet_style_qualification_for_method = false
dotnet_style_qualification_for_property = false

# Language keywords vs BCL types preferences
dotnet_style_predefined_type_for_locals_parameters_members = true
dotnet_style_predefined_type_for_member_access = true

# Parentheses preferences
dotnet_style_parentheses_in_arithmetic_binary_operators = always_for_clarity
dotnet_style_parentheses_in_other_binary_operators = always_for_clarity
dotnet_style_parentheses_in_other_operators = never_if_unnecessary
dotnet_style_parentheses_in_relational_binary_operators = always_for_clarity

# Modifier preferences
dotnet_style_require_accessibility_modifiers = for_non_interface_members

# Expression-level preferences
dotnet_style_coalesce_expression = true
dotnet_style_collection_initializer = true
dotnet_style_explicit_tuple_names = true
dotnet_style_namespace_match_folder = true
dotnet_style_null_propagation = true
dotnet_style_object_initializer = true
dotnet_style_operator_placement_when_wrapping = beginning_of_line
dotnet_style_prefer_auto_properties = true
dotnet_style_prefer_collection_expression = when_types_loosely_match
dotnet_style_prefer_compound_assignment = true
dotnet_style_prefer_conditional_expression_over_assignment = true
dotnet_style_prefer_conditional_expression_over_return = true
dotnet_style_prefer_foreach_explicit_cast_in_source = when_strongly_typed
dotnet_style_prefer_inferred_anonymous_type_member_names = true
dotnet_style_prefer_inferred_tuple_names = true
dotnet_style_prefer_is_null_check_over_reference_equality_method = true
dotnet_style_prefer_non_hidden_explicit_cast_in_source = true
dotnet_style_prefer_simplified_boolean_expressions = true
dotnet_style_prefer_simplified_interpolation = true
dotnet_prefer_system_hash_code = true

# Field preferences
dotnet_style_readonly_field = true

# Parameter preferences
dotnet_code_quality_unused_parameters = all:silent

# Suppression preferences
dotnet_remove_unnecessary_suppression_exclusions = none

# New line preferences
dotnet_style_allow_multiple_blank_lines_experimental = true
dotnet_style_allow_statement_immediately_after_block_experimental = true

#### C# Coding Conventions ####

# var preferences
csharp_style_var_elsewhere = false
csharp_style_var_for_built_in_types = false
csharp_style_var_when_type_is_apparent = false

# Expression-bodied members
csharp_style_expression_bodied_accessors = true
csharp_style_expression_bodied_constructors = false
csharp_style_expression_bodied_indexers = true
csharp_style_expression_bodied_lambdas = true
csharp_style_expression_bodied_local_functions = false
csharp_style_expression_bodied_methods = false
csharp_style_expression_bodied_operators = false
csharp_style_expression_bodied_properties = true

# Pattern matching preferences
csharp_style_pattern_matching_over_as_with_null_check = true
csharp_style_pattern_matching_over_is_with_cast_check = true
csharp_style_prefer_extended_property_pattern = true
csharp_style_prefer_not_pattern = true
csharp_style_prefer_pattern_matching = true
csharp_style_prefer_switch_expression = true

# Null-checking preferences
csharp_style_conditional_delegate_call = true

# Modifier preferences
csharp_prefer_static_local_function = true
csharp_preferred_modifier_order = public,private,protected,internal,file,static,extern,new,virtual,abstract,sealed,override,readonly,unsafe,required,volatile,async
csharp_style_prefer_readonly_struct = true
csharp_style_prefer_readonly_struct_member = true

# Code-block preferences
csharp_prefer_braces = true
csharp_prefer_simple_using_statement = true
csharp_style_namespace_declarations = block_scoped
csharp_style_prefer_method_group_conversion = true
csharp_style_prefer_primary_constructors = true
csharp_style_prefer_top_level_statements = true

# Expression-level preferences
csharp_prefer_simple_default_expression = true
csharp_style_deconstructed_variable_declaration = true
csharp_style_implicit_object_creation_when_type_is_apparent = true
csharp_style_inlined_variable_declaration = true
csharp_style_prefer_index_operator = true
csharp_style_prefer_local_over_anonymous_function = true
csharp_style_prefer_null_check_over_type_check = true
csharp_style_prefer_range_operator = true
csharp_style_prefer_tuple_swap = true
csharp_style_prefer_utf8_string_literals = true
csharp_style_throw_expression = true
csharp_style_unused_value_assignment_preference = discard_variable
csharp_style_unused_value_expression_statement_preference = discard_variable

# 'using' directive preferences
csharp_using_directive_placement = outside_namespace

# New line preferences
csharp_style_allow_blank_line_after_colon_in_constructor_initializer_experimental = true
csharp_style_allow_blank_line_after_token_in_arrow_expression_clause_experimental = true
csharp_style_allow_blank_line_after_token_in_conditional_expression_experimental = true
csharp_style_allow_blank_lines_between_consecutive_braces_experimental = true
csharp_style_allow_embedded_statements_on_same_line_experimental = true

#### C# Formatting Rules ####

# New line preferences
csharp_new_line_before_catch = true
csharp_new_line_before_else = true
csharp_new_line_before_finally = true
csharp_new_line_before_members_in_anonymous_types = true
csharp_new_line_before_members_in_object_initializers = true
csharp_new_line_before_open_brace = all
csharp_new_line_between_query_expression_clauses = true

# Indentation preferences
csharp_indent_block_contents = true
csharp_indent_braces = false
csharp_indent_case_contents = true
csharp_indent_case_contents_when_block = true
csharp_indent_labels = one_less_than_current
csharp_indent_switch_labels = true

# Space preferences
csharp_space_after_cast = false
csharp_space_after_colon_in_inheritance_clause = true
csharp_space_after_comma = true
csharp_space_after_dot = false
csharp_space_after_keywords_in_control_flow_statements = true
csharp_space_after_semicolon_in_for_statement = true
csharp_space_around_binary_operators = before_and_after
csharp_space_around_declaration_statements = false
csharp_space_before_colon_in_inheritance_clause = true
csharp_space_before_comma = false
csharp_space_before_dot = false
csharp_space_before_open_square_brackets = false
csharp_space_before_semicolon_in_for_statement = false
csharp_space_between_empty_square_brackets = false
csharp_space_between_method_call_empty_parameter_list_parentheses = false
csharp_space_between_method_call_name_and_opening_parenthesis = false
csharp_space_between_method_call_parameter_list_parentheses = false
csharp_space_between_method_declaration_empty_parameter_list_parentheses = false
csharp_space_between_method_declaration_name_and_open_parenthesis = false
csharp_space_between_method_declaration_parameter_list_parentheses = false
csharp_space_between_parentheses = false
csharp_space_between_square_brackets = false

# Wrapping preferences
csharp_preserve_single_line_blocks = true
csharp_preserve_single_line_statements = true

#### Naming styles ####

# Naming rules

dotnet_naming_rule.interface_should_be_begins_with_i.severity = suggestion
dotnet_naming_rule.interface_should_be_begins_with_i.symbols = interface
dotnet_naming_rule.interface_should_be_begins_with_i.style = begins_with_i

dotnet_naming_rule.types_should_be_pascal_case.severity = suggestion
dotnet_naming_rule.types_should_be_pascal_case.symbols = types
dotnet_naming_rule.types_should_be_pascal_case.style = pascal_case

dotnet_naming_rule.non_field_members_should_be_pascal_case.severity = suggestion
dotnet_naming_rule.non_field_members_should_be_pascal_case.symbols = non_field_members
dotnet_naming_rule.non_field_members_should_be_pascal_case.style = pascal_case

# Symbol specifications

dotnet_naming_symbols.interface.applicable_kinds = interface
dotnet_naming_symbols.interface.applicable_accessibilities = public, internal, private, protected, protected_internal, private_protected
dotnet_naming_symbols.interface.required_modifiers = 

dotnet_naming_symbols.types.applicable_kinds = class, struct, interface, enum
dotnet_naming_symbols.types.applicable_accessibilities = public, internal, private, protected, protected_internal, private_protected
dotnet_naming_symbols.types.required_modifiers = 

dotnet_naming_symbols.non_field_members.applicable_kinds = property, event, method
dotnet_naming_symbols.non_field_members.applicable_accessibilities = public, internal, private, protected, protected_internal, private_protected
dotnet_naming_symbols.non_field_members.required_modifiers = 

# Naming styles

dotnet_naming_style.pascal_case.required_prefix = 
dotnet_naming_style.pascal_case.required_suffix = 
dotnet_naming_style.pascal_case.word_separator = 
dotnet_naming_style.pascal_case.capitalization = pascal_case

dotnet_naming_style.begins_with_i.required_prefix = I
dotnet_naming_style.begins_with_i.required_suffix = 
dotnet_naming_style.begins_with_i.word_separator = 
dotnet_naming_style.begins_with_i.capitalization = pascal_case
````

---

## FILE: `.env-example`

````text
# AppConfig.
AppConfig__ConnectionString=Server=sqlserver;Database=ProjectTaskDb;User Id=sa;Password=${AppConfig__Password};TrustServerCertificate=True;
AppConfig__Password=<YOUR_PASSWORD>

# JwtSettings.
JwtSettings__Key=<LONG_KEY_MIN_LENGTH_32>

# ApiSettings.
ApiSettings__ApiUrl=http://web_api:8080
````

---

## FILE: `.gitignore`

````text
## Ignore Visual Studio temporary files, build results, and
## files generated by popular Visual Studio add-ons.
##
## Get latest from https://github.com/github/gitignore/blob/main/VisualStudio.gitignore

# User-specific files
*.rsuser
*.suo
*.user
*.userosscache
*.sln.docstates
*.env

# User-specific files (MonoDevelop/Xamarin Studio)
*.userprefs

# Mono auto generated files
mono_crash.*

# Build results
[Dd]ebug/
[Dd]ebugPublic/
[Rr]elease/
[Rr]eleases/

[Dd]ebug/x64/
[Dd]ebugPublic/x64/
[Rr]elease/x64/
[Rr]eleases/x64/
bin/x64/
obj/x64/

[Dd]ebug/x86/
[Dd]ebugPublic/x86/
[Rr]elease/x86/
[Rr]eleases/x86/
bin/x86/
obj/x86/

[Ww][Ii][Nn]32/
[Aa][Rr][Mm]/
[Aa][Rr][Mm]64/
[Aa][Rr][Mm]64[Ee][Cc]/
bld/
[Oo]bj/
[Oo]ut/
[Ll]og/
[Ll]ogs/

# Build results on 'Bin' directories
**/[Bb]in/*
# Uncomment if you have tasks that rely on *.refresh files to move binaries
# (https://github.com/github/gitignore/pull/3736)
#!**/[Bb]in/*.refresh

# Visual Studio 2015/2017 cache/options directory
.vs/
# Uncomment if you have tasks that create the project's static files in wwwroot
#wwwroot/

# Visual Studio 2017 auto generated files
Generated\ Files/

# MSTest test Results
[Tt]est[Rr]esult*/
[Bb]uild[Ll]og.*
*.trx

# NUnit
*.VisualState.xml
TestResult.xml
nunit-*.xml

# Approval Tests result files
*.received.*

# Build Results of an ATL Project
[Dd]ebugPS/
[Rr]eleasePS/
dlldata.c

# Benchmark Results
BenchmarkDotNet.Artifacts/

# .NET Core
project.lock.json
project.fragment.lock.json
artifacts/
.artifacts/

# ASP.NET Scaffolding
ScaffoldingReadMe.txt

# StyleCop
StyleCopReport.xml

# Files built by Visual Studio
*_i.c
*_p.c
*_h.h
*.ilk
*.meta
*.obj
*.idb
*.iobj
*.pch
*.pdb
*.ipdb
*.pgc
*.pgd
*.rsp
# but not Directory.Build.rsp, as it configures directory-level build defaults
!Directory.Build.rsp
*.sbr
*.tlb
*.tli
*.tlh
*.tmp
*.tmp_proj
*_wpftmp.csproj
*.log
*.tlog
*.vspscc
*.vssscc
.builds
*.pidb
*.svclog
*.scc

# Chutzpah Test files
_Chutzpah*

# Visual C++ cache files
ipch/
*.aps
*.ncb
*.opendb
*.opensdf
*.sdf
*.cachefile
*.VC.db
*.VC.VC.opendb

# Visual Studio profiler
*.psess
*.vsp
*.vspx
*.sap

# Visual Studio Trace Files
*.e2e

# TFS 2012 Local Workspace
$tf/

# Guidance Automation Toolkit
*.gpState

# ReSharper is a .NET coding add-in
_ReSharper*/
*.[Rr]e[Ss]harper
*.DotSettings.user

# TeamCity is a build add-in
_TeamCity*

# DotCover is a Code Coverage Tool
*.dotCover

# AxoCover is a Code Coverage Tool
.axoCover/*
!.axoCover/settings.json

# Coverlet is a free, cross platform Code Coverage Tool
coverage*.json
coverage*.xml
coverage*.info

# Visual Studio code coverage results
*.coverage
*.coveragexml

# NCrunch
_NCrunch_*
.NCrunch_*
.*crunch*.local.xml
nCrunchTemp_*

# MightyMoose
*.mm.*
AutoTest.Net/

# Web workbench (sass)
.sass-cache/

# Installshield output folder
[Ee]xpress/

# DocProject is a documentation generator add-in
DocProject/buildhelp/
DocProject/Help/*.HxT
DocProject/Help/*.HxC
DocProject/Help/*.hhc
DocProject/Help/*.hhk
DocProject/Help/*.hhp
DocProject/Help/Html2
DocProject/Help/html

# Click-Once directory
publish/

# Publish Web Output
*.[Pp]ublish.xml
*.azurePubxml
# Note: Comment the next line if you want to checkin your web deploy settings,
# but database connection strings (with potential passwords) will be unencrypted
*.pubxml
*.publishproj

# Microsoft Azure Web App publish settings. Comment the next line if you want to
# checkin your Azure Web App publish settings, but sensitive information contained
# in these scripts will be unencrypted
PublishScripts/

# NuGet Packages
*.nupkg
# NuGet Symbol Packages
*.snupkg
# The packages folder can be ignored because of Package Restore
**/[Pp]ackages/*
# except build/, which is used as an MSBuild target.
!**/[Pp]ackages/build/
# Uncomment if necessary however generally it will be regenerated when needed
#!**/[Pp]ackages/repositories.config
# NuGet v3's project.json files produces more ignorable files
*.nuget.props
*.nuget.targets

# Microsoft Azure Build Output
csx/
*.build.csdef

# Microsoft Azure Emulator
ecf/
rcf/

# Windows Store app package directories and files
AppPackages/
BundleArtifacts/
Package.StoreAssociation.xml
_pkginfo.txt
*.appx
*.appxbundle
*.appxupload

# Visual Studio cache files
# files ending in .cache can be ignored
*.[Cc]ache
# but keep track of directories ending in .cache
!?*.[Cc]ache/

# Others
ClientBin/
~$*
*~
*.dbmdl
*.dbproj.schemaview
*.jfm
*.pfx
*.publishsettings
orleans.codegen.cs

# Including strong name files can present a security risk
# (https://github.com/github/gitignore/pull/2483#issue-259490424)
#*.snk

# Since there are multiple workflows, uncomment next line to ignore bower_components
# (https://github.com/github/gitignore/pull/1529#issuecomment-104372622)
#bower_components/

# RIA/Silverlight projects
Generated_Code/

# Backup & report files from converting an old project file
# to a newer Visual Studio version. Backup files are not needed,
# because we have git ;-)
_UpgradeReport_Files/
Backup*/
UpgradeLog*.XML
UpgradeLog*.htm
ServiceFabricBackup/
*.rptproj.bak

# SQL Server files
*.mdf
*.ldf
*.ndf

# Business Intelligence projects
*.rdl.data
*.bim.layout
*.bim_*.settings
*.rptproj.rsuser
*- [Bb]ackup.rdl
*- [Bb]ackup ([0-9]).rdl
*- [Bb]ackup ([0-9][0-9]).rdl

# Microsoft Fakes
FakesAssemblies/

# GhostDoc plugin setting file
*.GhostDoc.xml

# Node.js Tools for Visual Studio
.ntvs_analysis.dat
node_modules/

# Visual Studio 6 build log
*.plg

# Visual Studio 6 workspace options file
*.opt

# Visual Studio 6 auto-generated workspace file (contains which files were open etc.)
*.vbw

# Visual Studio 6 workspace and project file (working project files containing files to include in project)
*.dsw
*.dsp

# Visual Studio 6 technical files
*.ncb
*.aps

# Visual Studio LightSwitch build output
**/*.HTMLClient/GeneratedArtifacts
**/*.DesktopClient/GeneratedArtifacts
**/*.DesktopClient/ModelManifest.xml
**/*.Server/GeneratedArtifacts
**/*.Server/ModelManifest.xml
_Pvt_Extensions

# Paket dependency manager
**/.paket/paket.exe
paket-files/

# FAKE - F# Make
**/.fake/

# CodeRush personal settings
**/.cr/personal

# Python Tools for Visual Studio (PTVS)
**/__pycache__/
*.pyc

# Cake - Uncomment if you are using it
#tools/**
#!tools/packages.config

# Tabs Studio
*.tss

# Telerik's JustMock configuration file
*.jmconfig

# BizTalk build output
*.btp.cs
*.btm.cs
*.odx.cs
*.xsd.cs

# OpenCover UI analysis results
OpenCover/

# Azure Stream Analytics local run output
ASALocalRun/

# MSBuild Binary and Structured Log
*.binlog
MSBuild_Logs/

# AWS SAM Build and Temporary Artifacts folder
.aws-sam

# NVidia Nsight GPU debugger configuration file
*.nvuser

# MFractors (Xamarin productivity tool) working folder
**/.mfractor/

# Local History for Visual Studio
**/.localhistory/

# Visual Studio History (VSHistory) files
.vshistory/

# BeatPulse healthcheck temp database
healthchecksdb

# Backup folder for Package Reference Convert tool in Visual Studio 2017
MigrationBackup/

# Ionide (cross platform F# VS Code tools) working folder
**/.ionide/

# Fody - auto-generated XML schema
FodyWeavers.xsd

# VS Code files for those working on multiple tools
.vscode/*
!.vscode/settings.json
!.vscode/tasks.json
!.vscode/launch.json
!.vscode/extensions.json
!.vscode/*.code-snippets

# Local History for Visual Studio Code
.history/

# Built Visual Studio Code Extensions
*.vsix

# Windows Installer files from build outputs
*.cab
*.msi
*.msix
*.msm
*.msp

# Official VS Code C# Dev Kit Extension exclusion
#*.lscache
````

---

## FILE: `Application/Application.csproj`

````text
﻿<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\Domain\Domain.csproj" />
    <ProjectReference Include="..\Shared\Shared.csproj" />
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="BCrypt.Net-Next" Version="4.2.0" />
    <PackageReference Include="MediatR" Version="14.2.0" />
    <PackageReference Include="Microsoft.Extensions.Options" Version="10.0.12" />
    <PackageReference Include="System.IdentityModel.Tokens.Jwt" Version="8.23.0" />
  </ItemGroup>

</Project>
````

---

## FILE: `Application/Attachments/Commands/DeleteAttachment/DeleteAttachmentCommand.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;

namespace Application.Attachments.Commands.DeleteAttachment;

public record DeleteAttachmentCommand(
    Guid AttachmentId) : IRequest<Result>;
````

---

## FILE: `Application/Attachments/Commands/DeleteAttachment/DeleteAttachmentHandler.cs`

````csharp
﻿using Application.Interfaces;
using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Interfaces.Files;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Attachments.Commands.DeleteAttachment;

public class DeleteAttachmentHandler
    : IRequestHandler<DeleteAttachmentCommand, Result>
{
    private readonly ITaskAttachmentQueryRepository _attachmentQueryRepository;
    private readonly IFileStorageService _fileStorage;
    private readonly ICurrentUser _currentUser;

    public DeleteAttachmentHandler(
        ITaskAttachmentQueryRepository attachmentQueryRepository,
        IFileStorageService fileStorage,
        ICurrentUser currentUser)
    {
        _attachmentQueryRepository = attachmentQueryRepository;
        _fileStorage = fileStorage;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        DeleteAttachmentCommand request,
        CancellationToken cancellationToken = default)
    {
        var attachment = await _attachmentQueryRepository.GetTrackedByIdAsync(
            request.AttachmentId,
            cancellationToken);

        if (attachment is null)
        {
            return Result.Failure(
                ErrorMessages.TaskAttachmentNotFound,
                ErrorType.NotFound);
        }

        if (attachment.UploadedByUserId != _currentUser.Id)
        {
            return Result.Failure(
                ErrorMessages.OnlyUploaderCanDeleteAttachment,
                ErrorType.Forbidden);
        }

        attachment.Delete();

        var relativePath = $"tasks/{attachment.TaskId}/{attachment.StoredFileName}";

        await _fileStorage.DeleteAsync(relativePath, cancellationToken);

        return Result.Success();
    }
}
````

---

## FILE: `Application/Attachments/Commands/UploadAttachment/UploadAttachmentCommand.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Attachments.Commands.UploadAttachment;

public record UploadAttachmentCommand(
    Guid TaskId,
    string FileName,
    string ContentType,
    long Size,
    Stream Content) : IRequest<Result<TaskAttachmentDto>>;
````

---

## FILE: `Application/Attachments/Commands/UploadAttachment/UploadAttachmentHandler.cs`

````csharp
﻿using Application.Interfaces;
using Application.Mappers;
using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Files;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.Attachments.Commands.UploadAttachment;

public class UploadAttachmentHandler
    : IRequestHandler<UploadAttachmentCommand, Result<TaskAttachmentDto>>
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ITaskAttachmentCommandRepository _attachmentCommandRepository;
    private readonly IFileStorageService _fileStorage;
    private readonly ICurrentUser _currentUser;

    public UploadAttachmentHandler(
        IProjectTaskQueryRepository taskQueryRepository,
        ITaskAttachmentCommandRepository attachmentCommandRepository,
        IFileStorageService fileStorage,
        ICurrentUser currentUser)
    {
        _taskQueryRepository = taskQueryRepository;
        _attachmentCommandRepository = attachmentCommandRepository;
        _fileStorage = fileStorage;
        _currentUser = currentUser;
    }

    public async Task<Result<TaskAttachmentDto>> Handle(
        UploadAttachmentCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetTrackedByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result<TaskAttachmentDto>.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        if (task.Status == ProjectTaskStatus.Done
            || task.Status == ProjectTaskStatus.Cancelled)
        {
            return Result<TaskAttachmentDto>.Failure(
                ErrorMessages.CannotAttachToClosedTask,
                ErrorType.Validation);
        }

        if (task.CustomerId != _currentUser.Id
            && task.ExecutorId != _currentUser.Id)
        {
            return Result<TaskAttachmentDto>.Failure(
                ErrorMessages.OnlyParticipantsCanAttach,
                ErrorType.Forbidden);
        }

        var extension = Path.GetExtension(request.FileName)
            .ToLowerInvariant();

        var storedFileName = $"{Guid.NewGuid():N}{extension}";

        var createResult = TaskAttachment.Create(
            request.TaskId,
            _currentUser.Id,
            request.FileName,
            storedFileName,
            request.ContentType,
            request.Size);

        if (!createResult.IsSuccess)
        {
            return Result<TaskAttachmentDto>.Failure(
                createResult.Message,
                ErrorType.Validation);
        }

        var attachment = createResult.Value!;
        var relativePath = $"tasks/{request.TaskId}/{storedFileName}";

        await _fileStorage.SaveAsync(
            request.Content,
            relativePath,
            cancellationToken);

        await _attachmentCommandRepository.AddAsync(attachment, cancellationToken);

        return Result<TaskAttachmentDto>.Success(TaskAttachmentMapper.ToDto(attachment));
    }
}
````

---

## FILE: `Application/Attachments/Queries/GetAttachmentFile/GetAttachmentFileHandler.cs`

````csharp
﻿using Application.Services.FileStorage;
using Domain.Constants;
using Domain.Interfaces.Files;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.Attachments.Queries.GetAttachmentFile;

public class GetAttachmentFileHandler
    : IRequestHandler<GetAttachmentFileQuery, Result<AttachmentFileResult>>
{
    private readonly ITaskAttachmentQueryRepository _attachmentQueryRepository;
    private readonly IFileStorageService _fileStorage;

    public GetAttachmentFileHandler(
        ITaskAttachmentQueryRepository attachmentQueryRepository,
        IFileStorageService fileStorage)
    {
        _attachmentQueryRepository = attachmentQueryRepository;
        _fileStorage = fileStorage;
    }

    public async Task<Result<AttachmentFileResult>> Handle(
        GetAttachmentFileQuery request,
        CancellationToken cancellationToken = default)
    {
        var attachment = await _attachmentQueryRepository.GetByIdAsync(
            request.AttachmentId,
            cancellationToken);

        if (attachment is null)
        {
            return Result<AttachmentFileResult>.Failure(
                ErrorMessages.TaskAttachmentNotFound,
                ErrorType.NotFound);
        }

        var relativePath = $"tasks/{attachment.TaskId}/{attachment.StoredFileName}";

        var fileResult = await _fileStorage.OpenReadAsync(
            relativePath,
            cancellationToken);

        if (!fileResult.IsSuccess)
        {
            return Result<AttachmentFileResult>.Failure(
                fileResult.Message,
                ErrorType.NotFound);
        }

        await using var stream = fileResult.Value!;

        using var ms = new MemoryStream();
        await stream.CopyToAsync(ms, cancellationToken);

        var result = new AttachmentFileResult
        {
            FileName = attachment.OriginalFileName,
            ContentType = attachment.ContentType,
            Content = ms.ToArray()
        };

        return Result<AttachmentFileResult>.Success(result);
    }
}
````

---

## FILE: `Application/Attachments/Queries/GetAttachmentFile/GetAttachmentFileQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Attachments.Queries.GetAttachmentFile;

public record GetAttachmentFileQuery(
    Guid AttachmentId) : IRequest<Result<AttachmentFileResult>>;
````

---

## FILE: `Application/Attachments/Queries/GetTaskAttachments/GetTaskAttachmentsHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Interfaces.Files;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Attachments.Queries;

public class GetTaskAttachmentsHandler
    : IRequestHandler<GetTaskAttachmentsQuery, Result<List<TaskAttachmentDto>>>
{
    private readonly ITaskAttachmentQueryRepository _attachmentQueryRepository;

    public GetTaskAttachmentsHandler(
        ITaskAttachmentQueryRepository attachmentQueryRepository)
    {
        _attachmentQueryRepository = attachmentQueryRepository;
    }

    public async Task<Result<List<TaskAttachmentDto>>> Handle(
        GetTaskAttachmentsQuery request,
        CancellationToken cancellationToken = default)
    {
        var attachments = await _attachmentQueryRepository.GetByTaskIdAsync(
            request.TaskId,
            cancellationToken);

        return Result<List<TaskAttachmentDto>>.Success(
            TaskAttachmentMapper.ToDtoList(attachments));
    }
}
````

---

## FILE: `Application/Attachments/Queries/GetTaskAttachments/GetTaskAttachmentsQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Attachments.Queries;

public record GetTaskAttachmentsQuery(
    Guid TaskId) : IRequest<Result<List<TaskAttachmentDto>>>;
````

---

## FILE: `Application/Behaviors/TransactionBehaviour.cs`

````csharp
﻿using Domain.Interfaces;
using MediatR;
using Shared.Dtos.Responses;

namespace Application.Behaviors;

public class TransactionBehaviour<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IUnitOfWork _unitOfWork;

    public TransactionBehaviour(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken = default)
    {
        var response = await next(cancellationToken);

        if (response is IResult { IsSuccess: false })
        {
            return response;
        }

        if (typeof(TRequest).Name.EndsWith("Query"))
        {
            return response;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return response;
    }
}
````

---

## FILE: `Application/Behaviors/UserActionLoggingBehavior.cs`

````csharp
﻿using Application.Common;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.UserActions;
using MediatR;
using Shared.Dtos.Responses;
using System.Reflection;

namespace Application.Behaviors;

public class UserActionLoggingBehavior<TRequest, TResponse>
    : IPipelineBehavior<TRequest, TResponse>
    where TRequest : notnull
{
    private readonly IUserActionCommandRepository _repository;
    private readonly ICurrentUser _currentUser;

    public UserActionLoggingBehavior(
        IUserActionCommandRepository repository,
        ICurrentUser currentUser)
    {
        _repository = repository;
        _currentUser = currentUser;
    }

    public async Task<TResponse> Handle(
        TRequest request,
        RequestHandlerDelegate<TResponse> next,
        CancellationToken cancellationToken)
    {
        var response = await next(cancellationToken);

        if (response is IResult { IsSuccess: false })
        {
            return response;
        }

        var attribute = typeof(TRequest).GetCustomAttribute<LogActionAttribute>(false);

        if (attribute is null)
        {
            return response;
        }

        var action = UserAction.Create(
            _currentUser.Id,
            attribute.ActionType,
            attribute.EntityType);

        await _repository.AddAsync(action, cancellationToken);

        return response;
    }
}
````

---

## FILE: `Application/Chats/Commands/AddMessage/AddMessageCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Chats.Commands.AddMessage;

[LogAction(UserActionType.SentMessage, nameof(Chat))]
public record AddMessageCommand(
    Guid ChatId,
    string Text) : IRequest<Result>;
````

---

## FILE: `Application/Chats/Commands/AddMessage/AddMessageHandler.cs`

````csharp
﻿using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Chats.Commands.AddMessage;

public class AddMessageHandler : IRequestHandler<AddMessageCommand, Result>
{
    private readonly IChatQueryRepository _queryRepository;
    private readonly IUserQueryRepository _userQueryRepository;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public AddMessageHandler(
        IChatQueryRepository queryRepository,
        IUserQueryRepository userQueryRepository,
        IProjectTaskQueryRepository taskQueryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _userQueryRepository = userQueryRepository;
        _taskQueryRepository = taskQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        AddMessageCommand request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetTrackedByIdAsync(
            request.ChatId,
            cancellationToken);

        if (chat is null)
        {
            return Result.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var task = await _taskQueryRepository.GetByIdAsync(chat.ProjectTaskId, cancellationToken);
        if (task is null
            || (task.CustomerId != _currentUser.Id
            && task.ExecutorId != _currentUser.Id))
        {
            return Result.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        var sender = await _userQueryRepository.GetByIdAsync(
            _currentUser.Id,
            cancellationToken);

        if (sender is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        var result = chat.AddMessage(request.Text, _currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Application/Chats/Commands/Create/CreateChatCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Commands.Create;

[LogAction(UserActionType.CreatedChat, nameof(Chat))]
public record CreateChatCommand(
    Guid ProjectTaskId) : IRequest<Result<ChatDto>>;
````

---

## FILE: `Application/Chats/Commands/Create/CreateChatHandler.cs`

````csharp
﻿using Application.Interfaces;
using Application.Mappers;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Commands.Create;

public class CreateChatHandler : IRequestHandler<CreateChatCommand, Result<ChatDto>>
{
    private readonly IChatCommandRepository _commandRepository;
    private readonly IChatQueryRepository _queryRepository;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public CreateChatHandler(
        IChatCommandRepository commandRepository,
        IChatQueryRepository queryRepository,
        IProjectTaskQueryRepository taskQueryRepository,
        ICurrentUser currentUser)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _taskQueryRepository = taskQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<ChatDto>> Handle(
        CreateChatCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetByIdAsync(request.ProjectTaskId, cancellationToken);

        if (task is null || (task.CustomerId != _currentUser.Id && task.ExecutorId != _currentUser.Id))
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        var existingChat = await _queryRepository.GetByTaskIdAsync(request.ProjectTaskId, cancellationToken);

        if (existingChat is not null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatAlreadyExists,
                ErrorType.Conflict);
        }

        var result = Chat.Create(request.ProjectTaskId);

        if (!result.IsSuccess)
        {
            return Result<ChatDto>.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(result.Value!, cancellationToken);

        var dto = ChatMapper.ToDto(result.Value!, new Dictionary<Guid, string>());

        return Result<ChatDto>.Success(dto);
    }
}
````

---

## FILE: `Application/Chats/Commands/Delete/DeleteChatCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Chats.Commands.Delete;

[LogAction(UserActionType.DeletedChat, nameof(Chat))]
public record DeleteChatCommand(
    Guid ChatId) : IRequest<Result>;
````

---

## FILE: `Application/Chats/Commands/Delete/DeleteChatHandler.cs`

````csharp
﻿using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Chats.Commands.Delete;

public class DeleteChatHandler : IRequestHandler<DeleteChatCommand, Result>
{
    private readonly IChatCommandRepository _commandRepository;
    private readonly IChatQueryRepository _queryRepository;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public DeleteChatHandler(
        IChatCommandRepository commandRepository,
        IChatQueryRepository queryRepository,
        IProjectTaskQueryRepository taskQueryRepository,
        ICurrentUser currentUser)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _taskQueryRepository = taskQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        DeleteChatCommand request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdAsync(
            request.ChatId,
            cancellationToken);

        if (chat is null)
        {
            return Result.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var task = await _taskQueryRepository.GetByIdAsync(
            chat.ProjectTaskId,
            cancellationToken);

        if (task is null
            || task.CustomerId != _currentUser.Id)
        {
            return Result.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        await _commandRepository.DeleteAsync(request.ChatId, cancellationToken);

        return Result.Success();
    }
}
````

---

## FILE: `Application/Chats/Queries/GetById/GetChatByIdHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Queries.GetById;

public class GetChatByIdHandler : IRequestHandler<GetChatByIdQuery, Result<ChatDto>>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatByIdHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<ChatDto>> Handle(
        GetChatByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdAsync(request.ChatId, cancellationToken);

        if (chat is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var userIds = chat.Messages.Select(m => m.UserId);
        var userNames = await _queryRepository.GetUserNamesAsync(userIds, cancellationToken);

        return Result<ChatDto>.Success(ChatMapper.ToDto(chat, userNames)!);
    }
}
````

---

## FILE: `Application/Chats/Queries/GetById/GetChatByIdQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Application.Chats.Queries.GetById;

public record GetChatByIdQuery(
    Guid ChatId) : IRequest<Result<ChatDto>>;
````

---

## FILE: `Application/Chats/Queries/GetByTaskId/GetChatByTaskIdHandler.cs`

````csharp
﻿using Application.Interfaces;
using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Chats;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Queries.GetByTaskId;

public class GetChatByTaskIdHandler : IRequestHandler<GetChatByTaskIdQuery, Result<ChatDto>>
{
    private readonly IChatQueryRepository _queryRepository;
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public GetChatByTaskIdHandler(
        IChatQueryRepository queryRepository,
        IProjectTaskQueryRepository taskQueryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _taskQueryRepository = taskQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result<ChatDto>> Handle(
        GetChatByTaskIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        if (task.CustomerId != _currentUser.Id
            && task.ExecutorId != _currentUser.Id)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.Forbidden,
                ErrorType.Forbidden);
        }

        var chat = await _queryRepository.GetByTaskIdAsync(
            request.TaskId,
            cancellationToken);

        if (chat is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var userIds = chat.Messages.Select(m => m.UserId);
        var userNames = await _queryRepository.GetUserNamesAsync(
            userIds,
            cancellationToken);

        return Result<ChatDto>.Success(ChatMapper.ToDto(chat, userNames));
    }
}
````

---

## FILE: `Application/Chats/Queries/GetByTaskId/GetChatByTaskIdQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Application.Chats.Queries.GetByTaskId;

public record GetChatByTaskIdQuery(
    Guid TaskId) : IRequest<Result<ChatDto>>;
````

---

## FILE: `Application/Chats/Queries/GetWithMessages/GetChatWithMessagesHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Chats;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;
using Shared.Enums;

namespace Application.Chats.Queries.GetWithMessages;

public class GetChatWithMessagesHandler : IRequestHandler<GetChatWithMessagesQuery, Result<ChatDto>>
{
    private readonly IChatQueryRepository _queryRepository;

    public GetChatWithMessagesHandler(IChatQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<ChatDto>> Handle(
    GetChatWithMessagesQuery request,
    CancellationToken cancellationToken = default)
    {
        var chat = await _queryRepository.GetByIdWithMessagesAsync(request.ChatId, cancellationToken);

        if (chat is null)
        {
            return Result<ChatDto>.Failure(
                ErrorMessages.ChatNotFound,
                ErrorType.NotFound);
        }

        var userIds = chat.Messages.Select(m => m.UserId);

        var userNames = await _queryRepository.GetUserNamesAsync(userIds, cancellationToken);

        return Result<ChatDto>.Success(ChatMapper.ToDto(chat, userNames));
    }
}
````

---

## FILE: `Application/Chats/Queries/GetWithMessages/GetChatWithMessagesQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Application.Chats.Queries.GetWithMessages;

public record GetChatWithMessagesQuery(
    Guid ChatId) : IRequest<Result<ChatDto>>;
````

---

## FILE: `Application/Common/LogActionAttribute.cs`

````csharp
﻿using Shared.Enums;

namespace Application.Common;

[AttributeUsage(AttributeTargets.Class)]
public sealed class LogActionAttribute : Attribute
{
    public UserActionType ActionType { get; }
    public string EntityType { get; }

    public LogActionAttribute(
        UserActionType actionType,
        string entityType)
    {
        ActionType = actionType;
        EntityType = entityType;
    }
}
````

---

## FILE: `Application/Interfaces/ICurrentUser.cs`

````csharp
﻿namespace Application.Interfaces;

public interface ICurrentUser
{
    Guid Id { get; }
    bool IsInRole(string role);
}
````

---

## FILE: `Application/Mappers/ChatMapper.cs`

````csharp
﻿using Domain.Entities;
using Shared.Dtos.Responses.Chats;

namespace Application.Mappers;

public static class ChatMapper
{
    public static ChatDto ToDto(
        Chat entity,
        IReadOnlyDictionary<Guid, string> userNames)
    {
        return new ChatDto(
            entity.Id,
            entity.ProjectTaskId,
            entity.Messages.Select(m => new MessageDto(
                m.Id,
                m.UserId,
                userNames.TryGetValue(m.UserId, out var name) ? name : "Unknown",
                m.Text,
                m.SentAt)
            ).ToList()
        );
    }
}
````

---

## FILE: `Application/Mappers/ProjectTaskMapper.cs`

````csharp
﻿using Domain.Entities;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Mappers;

public static class ProjectTaskMapper
{
    public static ProjectTaskDto ToDto(
        ProjectTask entity,
        string currency,
        bool isRespondedByCurrentUser = false)
    {
        return new ProjectTaskDto(
            entity.Id,
            entity.Title,
            entity.Description,
            entity.Price,
            entity.Status,
            entity.StartsAt,
            entity.EndsAt,
            isRespondedByCurrentUser,
            entity.ProjectRating,
            entity.CustomerId,
            entity.ExecutorId,
            currency);
    }

    public static PagedResult<ProjectTaskDto> ToPagedDto(
        PagedResult<ProjectTask> paged,
        string currency)
    {
        var dtos = paged.Collection
            .Select(t => ToDto(t, currency))
            .ToList();

        return PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);
    }

    public static List<TaskResponseDto> ToResponseDtos(ProjectTask entity)
    {
        if (entity.Responses is null || !entity.Responses.Any())
            return new List<TaskResponseDto>();

        return entity.Responses
            .Select(r => new TaskResponseDto
            {
                ExecutorId = r.ExecutorId,
                ExecutorName = $"Executor {r.ExecutorId}",
                RespondedAt = r.RespondedAt
            })
            .ToList();
    }
}
````

---

## FILE: `Application/Mappers/TaskAttachmentMapper.cs`

````csharp
﻿using Domain.Entities;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.Mappers;

public static class TaskAttachmentMapper
{
    public static TaskAttachmentDto ToDto(TaskAttachment entity)
    {
        return new TaskAttachmentDto(
            entity.Id,
            entity.TaskId,
            entity.UploadedByUserId,
            entity.OriginalFileName,
            entity.ContentType,
            entity.SizeBytes,
            entity.UploadedAt);
    }

    public static List<TaskAttachmentDto> ToDtoList(
        IReadOnlyCollection<TaskAttachment> entities)
    {
        return entities.Select(ToDto).ToList();
    }
}
````

---

## FILE: `Application/Mappers/UserMapper.cs`

````csharp
﻿using Domain.Entities;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Mappers;

public static class UserMapper
{
    public static UserDto ToDto(User entity)
    {
        return new UserDto(
            entity.Id,
            entity.Name,
            entity.Role,
            entity.Rating,
            entity.IsBlocked);
    }

    public static PagedResult<UserDto> ToPagedDto(PagedResult<User> paged)
    {
        var dtos = paged.Collection
            .Select(ToDto)
            .ToList();

        var pagedResult = PagedResult<UserDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return pagedResult;
    }
}
````

---

## FILE: `Application/ProjectTasks/Commands/AssignExecutor/AssignExecutorCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.AssignExecutor;

[LogAction(UserActionType.AssignedExecutor, nameof(ProjectTask))]
public record AssignExecutorCommand(
    Guid TaskId,
    Guid ExecutorId) : IRequest<Result>;
````

---

## FILE: `Application/ProjectTasks/Commands/AssignExecutor/AssignExecutorHandler.cs`

````csharp
﻿using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.AssignExecutor;

public class AssignExecutorHandler : IRequestHandler<AssignExecutorCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;

    public AssignExecutorHandler(
        IProjectTaskQueryRepository queryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        AssignExecutorCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetTrackedByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.AssignExecutor(
            request.ExecutorId,
            _currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Application/ProjectTasks/Commands/Cancel/CancelProjectTaskCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Cancel;

[LogAction(UserActionType.CancelledTask, nameof(ProjectTask))]
public record CancelProjectTaskCommand(
    Guid TaskId) : IRequest<Result>;
````

---

## FILE: `Application/ProjectTasks/Commands/Cancel/CancelProjectTaskHandler.cs`

````csharp
﻿using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Cancel;

public class CancelProjectTaskHandler : IRequestHandler<CancelProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;

    public CancelProjectTaskHandler(
        IProjectTaskQueryRepository queryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        CancelProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetTrackedByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.Cancel(_currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Application/ProjectTasks/Commands/Create/CreateProjectTaskCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Create;

[LogAction(UserActionType.CreatedTask, nameof(ProjectTask))]
public record class CreateProjectTaskCommand(
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt) : IRequest<Result<ProjectTaskDto>>;
````

---

## FILE: `Application/ProjectTasks/Commands/Create/CreateProjectTaskHandler.cs`

````csharp
﻿using Application.Interfaces;
using Application.Mappers;
using Domain.Config;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Create;

public class CreateProjectTaskHandler : IRequestHandler<CreateProjectTaskCommand, Result<ProjectTaskDto>>
{
    private readonly IProjectTaskCommandRepository _commandRepository;
    private readonly ICurrentUser _currentUser;
    private readonly string _currency;

    public CreateProjectTaskHandler(
        IProjectTaskCommandRepository commandRepository,
        IOptions<AppConfig> appConfig,
        ICurrentUser currentUser)
    {
        _commandRepository = commandRepository;
        _currency = appConfig.Value.Currency;
        _currentUser = currentUser;
    }

    public async Task<Result<ProjectTaskDto>> Handle(
        CreateProjectTaskCommand request,
        CancellationToken cancellationToken)
    {
        var result = ProjectTask.Create(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
            _currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result<ProjectTaskDto>.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(result.Value!);

        return Result<ProjectTaskDto>.Success(
            ProjectTaskMapper.ToDto(
                result.Value!,
                _currency));
    }
}
````

---

## FILE: `Application/ProjectTasks/Commands/Delete/DeleteProjectTaskCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Delete;

[LogAction(UserActionType.DeletedTask, nameof(ProjectTask))]
public record DeleteProjectTaskCommand(
    Guid TaskId) : IRequest<Result>;
````

---

## FILE: `Application/ProjectTasks/Commands/Delete/DeleteProjectTaskHandler.cs`

````csharp
﻿using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Delete;

public class DeleteProjectTaskHandler : IRequestHandler<DeleteProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly ICurrentUser _currentUser;

    public DeleteProjectTaskHandler(
        IProjectTaskQueryRepository taskQueryRepository,
        ICurrentUser currentUser)
    {
        _taskQueryRepository = taskQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        DeleteProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetTrackedByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(ErrorMessages.ProjectTaskNotFound, ErrorType.NotFound);
        }

        if (task.CustomerId != _currentUser.Id)
        {
            return Result.Failure(ErrorMessages.Forbidden, ErrorType.Forbidden);
        }

        task.Delete();

        return Result.Success();
    }
}
````

---

## FILE: `Application/ProjectTasks/Commands/MarkAsDone/MarkAsDoneCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.MarkAsDone;

[LogAction(UserActionType.MarkedTaskDone, nameof(ProjectTask))]
public record MarkAsDoneCommand(
    Guid TaskId,
    decimal? Rating) : IRequest<Result>;
````

---

## FILE: `Application/ProjectTasks/Commands/MarkAsDone/MarkAsDoneHandler.cs`

````csharp
﻿using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.MarkAsDone;

public class MarkAsDoneHandler : IRequestHandler<MarkAsDoneCommand, Result>
{
    private readonly IProjectTaskQueryRepository _taskQueryRepository;
    private readonly IUserQueryRepository _userQueryRepository;
    private readonly ICurrentUser _currentUser;

    public MarkAsDoneHandler(
        IProjectTaskQueryRepository taskQueryRepository,
        IUserQueryRepository userQueryRepository,
        ICurrentUser currentUser)
    {
        _taskQueryRepository = taskQueryRepository;
        _userQueryRepository = userQueryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        MarkAsDoneCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _taskQueryRepository.GetTrackedByIdAsync(
            request.TaskId,
            cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.MarkAsDone(_currentUser.Id, request.Rating);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        if (task.ExecutorId.HasValue && request.Rating.HasValue)
        {
            var executor = await _userQueryRepository.GetTrackedByIdAsync(
                task.ExecutorId.Value,
                cancellationToken);

            if (executor is not null)
            {
                var ratings = await _taskQueryRepository.GetRatingsByExecutorAsync(
                    executor.Id,
                    cancellationToken);

                executor.RecalculateRating(ratings);
            }
        }

        return Result.Success();
    }
}
````

---

## FILE: `Application/ProjectTasks/Commands/RespondToTask/RespondToTaskCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.RespondToTask;

[LogAction(UserActionType.RespondedToTask, nameof(ProjectTask))]
public record RespondToTaskCommand(
    Guid TaskId) : IRequest<Result>;
````

---

## FILE: `Application/ProjectTasks/Commands/RespondToTask/RespondToTaskHandler.cs`

````csharp
﻿using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.RespondToTask;

public class RespondToTaskHandler : IRequestHandler<RespondToTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;

    public RespondToTaskHandler(
        IProjectTaskQueryRepository queryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        RespondToTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetTrackedByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.RespondToTask(_currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Application/ProjectTasks/Commands/Update/UpdateProjectTaskCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Update;

[LogAction(UserActionType.UpdatedTask, nameof(ProjectTask))]
public record class UpdateProjectTaskCommand(
    Guid TaskId,
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt) : IRequest<Result>;
````

---

## FILE: `Application/ProjectTasks/Commands/Update/UpdateProjectTaskHandler.cs`

````csharp
﻿using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.ProjectTasks.Commands.Update;

public class UpdateProjectTaskHandler : IRequestHandler<UpdateProjectTaskCommand, Result>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly ICurrentUser _currentUser;

    public UpdateProjectTaskHandler(
        IProjectTaskQueryRepository queryRepository,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _currentUser = currentUser;
    }

    public async Task<Result> Handle(
        UpdateProjectTaskCommand request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetTrackedByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var result = task.Update(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt,
            _currentUser.Id);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Application/ProjectTasks/Queries/GetAssigned/GetAssignedTasksHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetAssigned;

public class GetAssignedTasksHandler : IRequestHandler<GetAssignedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public GetAssignedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetAssignedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _queryRepository.GetByExecutorIdAsync(
            request.ExecutorId,
            request.Page,
            request.PageSize,
            cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(
            ProjectTaskMapper.ToPagedDto(
                paged,
                _appConfig.Currency));
    }
}
````

---

## FILE: `Application/ProjectTasks/Queries/GetAssigned/GetAssignedTasksQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetAssigned;

public record GetAssignedTasksQuery(
    Guid ExecutorId,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTaskDto>>>;
````

---

## FILE: `Application/ProjectTasks/Queries/GetByCustomer/GetTasksByCustomerHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public class GetTasksByCustomerHandler : IRequestHandler<GetTasksByCustomerQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public GetTasksByCustomerHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetTasksByCustomerQuery request,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _queryRepository.GetByCustomerIdAsync(
            request.CustomerId,
            request.Page,
            request.PageSize,
            cancellationToken);

        return Result<PagedResult<ProjectTaskDto>>.Success(
            ProjectTaskMapper.ToPagedDto(projectTask, _appConfig.Currency));
    }
}
````

---

## FILE: `Application/ProjectTasks/Queries/GetByCustomer/GetTasksByCustomerQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetTasksByCustomer;

public record GetTasksByCustomerQuery(
    Guid CustomerId,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTaskDto>>>;
````

---

## FILE: `Application/ProjectTasks/Queries/GetById/GetProjectTaskByIdHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Config;
using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public class GetProjectTaskByIdHandler : IRequestHandler<GetProjectTaskByIdQuery, Result<ProjectTaskDto>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public GetProjectTaskByIdHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
    }

    public async Task<Result<ProjectTaskDto>> Handle(
        GetProjectTaskByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (projectTask is null)
        {
            return Result<ProjectTaskDto>.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        return Result<ProjectTaskDto>.Success(
            ProjectTaskMapper.ToDto(
                projectTask!,
                _appConfig.Currency));
    }
}
````

---

## FILE: `Application/ProjectTasks/Queries/GetById/GetProjectTaskByIdQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetProjectTaskById;

public record GetProjectTaskByIdQuery(
    Guid TaskId) : IRequest<Result<ProjectTaskDto>>;
````

---

## FILE: `Application/ProjectTasks/Queries/GetPublished/GetPublishedTasksHandler.cs`

````csharp
﻿using Application.Interfaces;
using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public class GetPublishedTasksHandler : IRequestHandler<GetPublishedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;
    private readonly ICurrentUser _currentUser;

    public GetPublishedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig,
        ICurrentUser currentUser)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
        _currentUser = currentUser;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        GetPublishedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.GetPublishedAsync(
            request.Page,
            request.PageSize,
            cancellationToken);

        var dtos = pagedResult.Collection
            .Select(t => ProjectTaskMapper.ToDto(
                t,
                _appConfig.Currency,
                t.Responses.Any(r => r.ExecutorId == _currentUser.Id)))
            .ToList();

        var result = PagedResult<ProjectTaskDto>.Create(
            dtos,
            pagedResult.Page,
            pagedResult.PageSize,
            pagedResult.TotalCount);

        return Result<PagedResult<ProjectTaskDto>>.Success(result);
    }
}
````

---

## FILE: `Application/ProjectTasks/Queries/GetPublished/GetPublishedTasksQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetPublishedTasks;

public record GetPublishedTasksQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<ProjectTaskDto>>>;
````

---

## FILE: `Application/ProjectTasks/Queries/GetResponses/GetTaskResponsesHandler.cs`

````csharp
﻿using Domain.Constants;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Application.ProjectTasks.Queries.GetResponses;

public class GetTaskResponsesHandler : IRequestHandler<GetTaskResponsesQuery, Result<List<TaskResponseDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;

    public GetTaskResponsesHandler(IProjectTaskQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<List<TaskResponseDto>>> Handle(
        GetTaskResponsesQuery request,
        CancellationToken cancellationToken = default)
    {
        var task = await _queryRepository.GetByIdAsync(request.TaskId, cancellationToken);

        if (task is null)
        {
            return Result<List<TaskResponseDto>>.Failure(
                ErrorMessages.ProjectTaskNotFound,
                ErrorType.NotFound);
        }

        var responses = await _queryRepository.GetResponsesByTaskIdAsync(request.TaskId, cancellationToken);

        return Result<List<TaskResponseDto>>.Success(responses);
    }
}
````

---

## FILE: `Application/ProjectTasks/Queries/GetResponses/GetTaskResponsesQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.GetResponses;

public record GetTaskResponsesQuery(
    Guid TaskId) : IRequest<Result<List<TaskResponseDto>>>;
````

---

## FILE: `Application/ProjectTasks/Queries/SearchTasks/ISearchTasksQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.SearchTasks;

public interface ISearchTasksQuery
    : IRequest<Result<PagedResult<ProjectTaskDto>>>;
````

---

## FILE: `Application/ProjectTasks/Queries/SearchTasks/SearchCustomerTasksHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.SearchTasks;

public class SearchCustomerTasksHandler
    : IRequestHandler<SearchCustomerTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public SearchCustomerTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        SearchCustomerTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _queryRepository.SearchByCustomerIdAsync(
            request.CustomerId,
            request.Query,
            request.Page,
            request.PageSize,
            cancellationToken);

        var dtos = paged.Collection
             .Select(t => ProjectTaskMapper.ToDto(t, _appConfig.Currency))
             .ToList();

        var result = PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<ProjectTaskDto>>.Success(result);
    }
}
````

---

## FILE: `Application/ProjectTasks/Queries/SearchTasks/SearchCustomerTasksQuery.cs`

````csharp
﻿namespace Application.ProjectTasks.Queries.SearchTasks;

public record SearchCustomerTasksQuery(
    Guid CustomerId,
    string Query,
    int Page,
    int PageSize) : ISearchTasksQuery;
````

---

## FILE: `Application/ProjectTasks/Queries/SearchTasks/SearchPublishedTasksHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Config;
using Domain.Interfaces.ProjectTasks;
using MediatR;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Application.ProjectTasks.Queries.SearchTasks;

public class SearchPublishedTasksHandler
    : IRequestHandler<SearchPublishedTasksQuery, Result<PagedResult<ProjectTaskDto>>>
{
    private readonly IProjectTaskQueryRepository _queryRepository;
    private readonly AppConfig _appConfig;

    public SearchPublishedTasksHandler(
        IProjectTaskQueryRepository queryRepository,
        IOptions<AppConfig> appConfig)
    {
        _queryRepository = queryRepository;
        _appConfig = appConfig.Value;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> Handle(
        SearchPublishedTasksQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _queryRepository.SearchPublishedAsync(
            request.Query,
            request.Page,
            request.PageSize,
            cancellationToken);

        var dtos = paged.Collection
            .Select(t => ProjectTaskMapper.ToDto(
                t,
                _appConfig.Currency,
                t.Responses.Any(r => r.ExecutorId == request.CurrentUserId)))
            .ToList();

        var result = PagedResult<ProjectTaskDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<ProjectTaskDto>>.Success(result);
    }
}
````

---

## FILE: `Application/ProjectTasks/Queries/SearchTasks/SearchPublishedTasksQuery.cs`

````csharp
﻿namespace Application.ProjectTasks.Queries.SearchTasks;

public record SearchPublishedTasksQuery(
    string Query,
    int Page,
    int PageSize,
    Guid CurrentUserId) : ISearchTasksQuery;
````

---

## FILE: `Application/ProjectTasks/Queries/SearchTasks/SearchTasksQueryFactory.cs`

````csharp
﻿using Application.Interfaces;

namespace Application.ProjectTasks.Queries.SearchTasks;

public class SearchTasksQueryFactory
{
    public static ISearchTasksQuery Create(
        ICurrentUser currentUser,
        bool isCustomer,
        string query,
        int page,
        int pageSize)
    {
        return isCustomer
            ? new SearchCustomerTasksQuery(currentUser.Id, query, page, pageSize)
            : new SearchPublishedTasksQuery(query, page, pageSize, currentUser.Id);
    }
}
````

---

## FILE: `Application/Services/FileStorage/FileStorageService.cs`

````csharp
﻿using Domain.Config;
using Domain.Constants;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;

namespace Application.Services.FileStorage;

public class FileStorageService : IFileStorageService
{
    private readonly string _root;

    public FileStorageService(IOptions<FileSettings> fileSettings)
    {
        _root = fileSettings.Value.FullPath;
        Directory.CreateDirectory(_root);
    }

    private Result<string> FullPath(string relativePath)
    {
        var combined = Path.Combine(_root, relativePath.Replace('/', Path.DirectorySeparatorChar));

        var fullPath = Path.GetFullPath(combined);

        var rootFullPath = Path.GetFullPath(_root);

        if (!fullPath.StartsWith(rootFullPath, StringComparison.OrdinalIgnoreCase))
        {
            return Result<string>.Failure(ErrorMessages.InvalidFilePath);
        }

        return Result<string>.Success(fullPath);
    }

    public async Task<Result> SaveAsync(
        Stream stream,
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var pathResult = FullPath(relativePath);

        if (!pathResult.IsSuccess || pathResult.Value is null)
        {
            return Result.Failure(pathResult.Message);
        }

        var fullPath = pathResult.Value;

        Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);

        await using var fileStream = new FileStream(
            fullPath,
            FileMode.Create,
            FileAccess.Write,
            FileShare.None,
            bufferSize: 81920,
            useAsync: true);

        await stream.CopyToAsync(fileStream, cancellationToken);

        return Result.Success();
    }

    public async Task<Result<Stream>> OpenReadAsync(
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var pathResult = FullPath(relativePath);

        if (!pathResult.IsSuccess || pathResult.Value is null)
        {
            return Result<Stream>.Failure(pathResult.Message);
        }

        var fullPath = pathResult.Value;

        if (!File.Exists(fullPath))
        {
            return Result<Stream>.Failure(ErrorMessages.TaskAttachmentNotFound);
        }

        Stream stream = new FileStream(
            fullPath,
            FileMode.Open,
            FileAccess.Read,
            FileShare.Read,
            bufferSize: 81920,
            useAsync: true);

        return Result<Stream>.Success(stream);
    }

    public Task<Result> DeleteAsync(
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var pathResult = FullPath(relativePath);

        if (!pathResult.IsSuccess || pathResult.Value is null)
        {
            return Task.FromResult(Result.Failure(pathResult.Message));
        }

        var fullPath = pathResult.Value;

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }

        return Task.FromResult(Result.Success());
    }
}
````

---

## FILE: `Application/Services/FileStorage/IFileStorageService.cs`

````csharp
﻿using Shared.Dtos.Responses;

namespace Application.Services.FileStorage;

public interface IFileStorageService
{
    Task<Result> SaveAsync(Stream stream, string relativePath, CancellationToken cancellationToken = default);
    Task<Result<Stream>> OpenReadAsync(string relativePath, CancellationToken cancellationToken = default);
    Task<Result> DeleteAsync(string relativePath, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Application/Services/Hasher/IPasswordHasher.cs`

````csharp
﻿using Shared.Dtos.Responses;

namespace Application.Services.Hasher;

public interface IPasswordHasher
{
    Result<string> Hash(string password);
    Result Verify(string password, string passwordHash);
}
````

---

## FILE: `Application/Services/Hasher/PasswordHasher.cs`

````csharp
﻿using Domain.Constants;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Services.Hasher;

public class PasswordHasher : IPasswordHasher
{
    public Result<string> Hash(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            return Result<string>.Failure(
                ErrorMessages.PasswordCannotBeEmpty,
                ErrorType.Validation);
        }

        var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

        return Result<string>.Success(passwordHash);
    }

    public Result Verify(string password, string passwordHash)
    {
        if (string.IsNullOrEmpty(password))
        {
            return Result.Failure(
                ErrorMessages.PasswordCannotBeEmpty,
                ErrorType.Validation);
        }

        if (string.IsNullOrEmpty(passwordHash))
        {
            return Result.Failure(
                ErrorMessages.PasswordHashCannotBeEmpty,
                ErrorType.Validation);
        }

        var isVerified = BCrypt.Net.BCrypt.Verify(password, passwordHash);

        if (!isVerified)
        {
            return Result.Failure(
                ErrorMessages.IncorrectLoginOrPassword,
                ErrorType.Validation);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Application/Services/JwtGenerator/IJwtTokenGenerator.cs`

````csharp
﻿using Domain.Entities;
using Shared.Dtos.Responses.Users;

namespace Application.Services.JwtGenerator;

public interface IJwtTokenGenerator
{
    AuthDto GenerateToken(User user);
}
````

---

## FILE: `Application/Services/JwtGenerator/JwtTokenGenerator.cs`

````csharp
﻿using Domain.Config;
using Domain.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Shared.Dtos.Responses.Users;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Application.Services.JwtGenerator;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly JwtSettings _jwtSettings;

    public JwtTokenGenerator(IOptions<JwtSettings> jwtSettings)
    {
        _jwtSettings = jwtSettings.Value;
    }

    public AuthDto GenerateToken(User user)
    {
        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new(ClaimTypes.Name, user.Name),
            new(ClaimTypes.Role, user.Role.ToString())
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddHours(_jwtSettings.ExpiresHours),
            Audience = _jwtSettings.ValidAudiences.FirstOrDefault(),
            Issuer = _jwtSettings.ValidIssuers.FirstOrDefault(),
            SigningCredentials = credentials
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);

        var authDto = new AuthDto(
            tokenHandler.WriteToken(token),
            user.Name,
            user.Role.ToString(),
            user.Id.ToString());

        return authDto;
    }
}
````

---

## FILE: `Application/UserActions/Queries/GetUserActions/GetUserActionsHandler.cs`

````csharp
﻿using Domain.Interfaces.UserActions;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Application.UserActions.Queries.GetUserActions;

public class GetUserActionsHandler
    : IRequestHandler<GetUserActionsQuery, Result<PagedResult<UserActionDto>>>
{
    private readonly IUserActionQueryRepository _actionRepository;
    private readonly IUserQueryRepository _userRepository;

    public GetUserActionsHandler(
        IUserActionQueryRepository actionRepository,
        IUserQueryRepository userRepository)
    {
        _actionRepository = actionRepository;
        _userRepository = userRepository;
    }

    public async Task<Result<PagedResult<UserActionDto>>> Handle(
        GetUserActionsQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _actionRepository.GetAsync(
            request.UserId,
            request.ActionType,
            request.Page,
            request.PageSize,
            cancellationToken);

        if (paged.TotalCount == 0)
        {
            return Result<PagedResult<UserActionDto>>.Success(
                PagedResult<UserActionDto>.Empty(request.Page, request.PageSize));
        }

        var userIds = paged.Collection
            .Select(a => a.UserId)
            .Distinct()
            .ToList();

        var users = await _userRepository.GetNamesByIdsAsync(userIds, cancellationToken);

        var dtos = paged.Collection
            .Select(a => new UserActionDto
            {
                Id = a.Id,
                UserId = a.UserId,
                UserName = users.TryGetValue(a.UserId, out var name) ? name : "Unknown",
                ActionType = a.ActionType,
                EntityType = a.EntityType,
                PerformedAt = a.PerformedAt
            })
            .ToList();

        var result = PagedResult<UserActionDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<UserActionDto>>.Success(result);
    }
}
````

---

## FILE: `Application/UserActions/Queries/GetUserActions/GetUserActionsQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Application.UserActions.Queries.GetUserActions;

public record GetUserActionsQuery(
    Guid? UserId,
    int? ActionType,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserActionDto>>>;
````

---

## FILE: `Application/Users/Commands/BlockUser/BlockUserCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.BlockUser;

[LogAction(UserActionType.UserBlocked, nameof(User))]
public record BlockUserCommand(
    Guid TargetUserId) : IRequest<Result>;
````

---

## FILE: `Application/Users/Commands/BlockUser/BlockUserHandler.cs`

````csharp
﻿using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.BlockUser;

public class BlockUserHandler : IRequestHandler<BlockUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;

    public BlockUserHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result> Handle(
        BlockUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetTrackedByIdAsync(
            request.TargetUserId,
            cancellationToken);

        if (user is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        user.Block();

        return Result.Success();
    }
}
````

---

## FILE: `Application/Users/Commands/ChangeRole/ChangeRoleCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.ChangeRole;

[LogAction(UserActionType.UserRoleChanged, nameof(User))]
public record ChangeRoleCommand(
    Guid TargetUserId,
    UserRole NewRole) : IRequest<Result>;
````

---

## FILE: `Application/Users/Commands/ChangeRole/ChangeRoleHandler.cs`

````csharp
﻿using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.ChangeRole;

public class ChangeRoleHandler : IRequestHandler<ChangeRoleCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;

    public ChangeRoleHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result> Handle(
        ChangeRoleCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetTrackedByIdAsync(
            request.TargetUserId,
            cancellationToken);

        if (user is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        var result = user.ChangeRole(request.NewRole);

        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message, ErrorType.Validation);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Application/Users/Commands/Delete/DeleteUserCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.Delete;

[LogAction(UserActionType.UserDeleted, nameof(User))]
public record DeleteUserCommand(
    Guid TargetUserId) : IRequest<Result>;
````

---

## FILE: `Application/Users/Commands/Delete/DeleteUserHandler.cs`

````csharp
﻿using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.Delete;

public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;

    public DeleteUserHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result> Handle(
        DeleteUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetTrackedByIdAsync(
            request.TargetUserId,
            cancellationToken);

        if (user is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        user.Delete();

        return Result.Success();
    }
}
````

---

## FILE: `Application/Users/Commands/Login/LoginUserCommand.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Commands.Login;

public record LoginUserCommand(
    string Name,
    string Password) : IRequest<Result<AuthDto>>;
````

---

## FILE: `Application/Users/Commands/Login/LoginUserHandler.cs`

````csharp
﻿using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Application.Users.Commands.Login;

public class LoginUserHandler : IRequestHandler<LoginUserCommand, Result<AuthDto>>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IPasswordHasher _passwordHasher;

    public LoginUserHandler(
        IUserQueryRepository queryRepository,
        IJwtTokenGenerator jwtTokenGenerator,
        IPasswordHasher passwordHasher)
    {
        _queryRepository = queryRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _passwordHasher = passwordHasher;
    }

    public async Task<Result<AuthDto>> Handle(
        LoginUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetByNameAsync(
            request.Name,
            cancellationToken);

        if (user is null)
        {
            return Result<AuthDto>.Failure(
                ErrorMessages.UsersNotFound,
                ErrorType.NotFound);
        }

        if (user.IsBlocked)
        {
            return Result<AuthDto>.Failure(
                ErrorMessages.UserIsBlocked,
                ErrorType.Validation);
        }

        var result = _passwordHasher.Verify(
            request.Password,
            user.PasswordHash);

        if (!result.IsSuccess)
        {
            return Result<AuthDto>.Failure(
                result.Message,
                ErrorType.Validation);
        }

        var authDto = _jwtTokenGenerator.GenerateToken(user);

        return Result<AuthDto>.Success(authDto);
    }
}
````

---

## FILE: `Application/Users/Commands/Register/RegisterUserCommand.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Application.Users.Commands.Register;

public record RegisterUserCommand(
    string Name,
    string Password,
    UserRole Role) : IRequest<Result<AuthDto>>;
````

---

## FILE: `Application/Users/Commands/Register/RegisterUserHandler.cs`

````csharp
﻿using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Application.Users.Commands.Register;

public class RegisterUserHandler : IRequestHandler<RegisterUserCommand, Result<AuthDto>>
{
    private readonly IUserCommandRepository _commandRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RegisterUserHandler(
        IUserCommandRepository commandRepository,
        IJwtTokenGenerator jwtTokenGenerator,
        IPasswordHasher passwordHasher,
        IUserQueryRepository queryRepository,
        IUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _passwordHasher = passwordHasher;
        _queryRepository = queryRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<AuthDto>> Handle(
        RegisterUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var existing = await _queryRepository.GetByNameAsync(request.Name, cancellationToken);

        if (existing is not null)
        {
            return Result<AuthDto>.Failure(
                ErrorMessages.UserAlreadyExists,
                ErrorType.Conflict);
        }

        var hashResult = _passwordHasher.Hash(request.Password);

        if (!hashResult.IsSuccess)
        {
            return Result<AuthDto>.Failure(
                hashResult.Message,
                ErrorType.Validation);
        }

        var userResult = User.Create(
            request.Name,
            hashResult.Value!,
            request.Role);

        if (!userResult.IsSuccess)
        {
            return Result<AuthDto>.Failure(
                userResult.Message,
                ErrorType.Validation);
        }

        await _commandRepository.AddAsync(userResult.Value!, cancellationToken);

        var authDto = _jwtTokenGenerator.GenerateToken(userResult.Value!);

        return Result<AuthDto>.Success(authDto);
    }
}
````

---

## FILE: `Application/Users/Commands/UnblockUser/UnblockUserCommand.cs`

````csharp
﻿using Application.Common;
using Domain.Entities;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.UnblockUser;

[LogAction(UserActionType.UserUnblocked, nameof(User))]
public record UnblockUserCommand(
    Guid TargetUserId) : IRequest<Result>;
````

---

## FILE: `Application/Users/Commands/UnblockUser/UnblockUserHandler.cs`

````csharp
﻿using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.UnblockUser;

public class UnblockUserHandler : IRequestHandler<UnblockUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;

    public UnblockUserHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result> Handle(
        UnblockUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetTrackedByIdAsync(
            request.TargetUserId,
            cancellationToken);

        if (user is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        user.Unblock();

        return Result.Success();
    }
}
````

---

## FILE: `Application/Users/Commands/Update/UpdateUserCommand.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;

namespace Application.Users.Commands.Update;

public record UpdateUserCommand(
    Guid TargetUserId,
    string Name) : IRequest<Result>;
````

---

## FILE: `Application/Users/Commands/Update/UpdateUserHandler.cs`

````csharp
﻿using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Application.Users.Commands.Update;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, Result>
{
    private readonly IUserQueryRepository _queryRepository;
    private readonly IUserCommandRepository _commandRepository;

    public UpdateUserHandler(
        IUserQueryRepository queryRepository,
        IUserCommandRepository commandRepository)
    {
        _queryRepository = queryRepository;
        _commandRepository = commandRepository;
    }

    public async Task<Result> Handle(
        UpdateUserCommand request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetTrackedByIdAsync(request.TargetUserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        var result = user.Update(request.Name);

        if (!result.IsSuccess)
        {
            return Result.Failure(
                result.Message,
                ErrorType.Validation);
        }

        await _commandRepository.UpdateAsync(user, cancellationToken);

        return Result.Success();
    }
}
````

---

## FILE: `Application/Users/Queries/GetAll/GetAllUsersHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.GetAll;

public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, Result<PagedResult<UserDto>>>
{
    private readonly IUserQueryRepository _queryRepository;

    public GetAllUsersHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<UserDto>>> Handle(
        GetAllUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.GetAllAsync(
            request.Page,
            request.PageSize,
            cancellationToken);

        return Result<PagedResult<UserDto>>.Success(UserMapper.ToPagedDto(pagedResult));
    }
}
````

---

## FILE: `Application/Users/Queries/GetAll/GetAllUsersQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.GetAll;

public record GetAllUsersQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;
````

---

## FILE: `Application/Users/Queries/GetById/GetUserByIdHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Application.Users.Queries.GetById;

public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, Result<UserDto>>
{
    private readonly IUserQueryRepository _queryRepository;

    public GetUserByIdHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<UserDto>> Handle(
        GetUserByIdQuery request,
        CancellationToken cancellationToken = default)
    {
        var user = await _queryRepository.GetByIdAsync(
            request.UserId,
            cancellationToken);

        if (user is null)
        {
            return Result<UserDto>.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        return Result<UserDto>.Success(UserMapper.ToDto(user));
    }
}
````

---

## FILE: `Application/Users/Queries/GetById/GetUserByIdQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.GetById;

public record GetUserByIdQuery(
    Guid UserId) : IRequest<Result<UserDto>>;
````

---

## FILE: `Application/Users/Queries/GetUsers/GetUsersHandler.cs`

````csharp
﻿using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.GetUsers;

public class GetUsersHandler : IRequestHandler<GetUsersQuery, Result<PagedResult<UserDto>>>
{
    private readonly IUserQueryRepository _userRepository;

    public GetUsersHandler(IUserQueryRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<PagedResult<UserDto>>> Handle(
        GetUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        var paged = await _userRepository.GetPagedAsync(
            request.Page,
            request.PageSize,
            cancellationToken);

        var dtos = paged.Collection
            .Select(u => new UserDto
            (
                u.Id,
                u.Name,
                u.Role,
                u.Rating,
                u.IsBlocked
            ))
            .ToList();

        var result = PagedResult<UserDto>.Create(
            dtos,
            paged.Page,
            paged.PageSize,
            paged.TotalCount);

        return Result<PagedResult<UserDto>>.Success(result);
    }
}
````

---

## FILE: `Application/Users/Queries/GetUsers/GetUsersQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.GetUsers;

public record GetUsersQuery(
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;
````

---

## FILE: `Application/Users/Queries/SearchByName/SearchUsersHandler.cs`

````csharp
﻿using Application.Mappers;
using Domain.Constants;
using Domain.Interfaces.Users;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Application.Users.Queries.SearchByName;

public class SearchUsersHandler : IRequestHandler<SearchUsersQuery, Result<PagedResult<UserDto>>>
{
    private readonly IUserQueryRepository _queryRepository;

    public SearchUsersHandler(IUserQueryRepository queryRepository)
    {
        _queryRepository = queryRepository;
    }

    public async Task<Result<PagedResult<UserDto>>> Handle(
        SearchUsersQuery request,
        CancellationToken cancellationToken = default)
    {
        var pagedResult = await _queryRepository.SearchByNameAsync(request.SearchQuery, request.Page, request.PageSize, cancellationToken);

        if (pagedResult is null)
        {
            return Result<PagedResult<UserDto>>.Failure(
                ErrorMessages.UserNotFound,
                ErrorType.NotFound);
        }

        return Result<PagedResult<UserDto>>.Success(UserMapper.ToPagedDto(pagedResult));
    }
}
````

---

## FILE: `Application/Users/Queries/SearchByName/SearchUsersQuery.cs`

````csharp
﻿using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Application.Users.Queries.SearchByName;

public record SearchUsersQuery(
    string SearchQuery,
    int Page,
    int PageSize) : IRequest<Result<PagedResult<UserDto>>>;
````

---

## FILE: `Blazor Web App/appsettings.Development.json`

````json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
````

---

## FILE: `Blazor Web App/appsettings.json`

````json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
````

---

## FILE: `Blazor Web App/Blazor Web App.csproj`

````text
﻿<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>Blazor_Web_App</RootNamespace>
    <AssemblyName>$(AssemblyName.Replace(' ', '_'))</AssemblyName>
    <BlazorDisableThrowNavigationException>true</BlazorDisableThrowNavigationException>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\Shared\Shared.csproj" />
  </ItemGroup>

</Project>
````

---

## FILE: `Blazor Web App/Components/App.razor`

````text
﻿<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <base href="/" />
    <ResourcePreloader />
    <link rel="stylesheet" href="@Assets["lib/bootstrap/dist/css/bootstrap.min.css"]" />
    <link rel="stylesheet" href="@Assets["app.css"]" />
    <link rel="stylesheet" href="@Assets["Blazor_Web_App.styles.css"]" />
    <ImportMap />
    <link rel="icon" type="image/png" href="favicon.png" />
    <HeadOutlet />
</head>

<body>
    <Routes />
    <ReconnectModal />
    <script src="download.js"></script>
    <script src="@Assets["_framework/blazor.web.js"]"></script>
</body>

</html>
````

---

## FILE: `Blazor Web App/Components/Layout/CultureSelector.razor`

````text
﻿@using Blazor_Web_App.Constants

<select class="form-select form-select-sm" value="@_current" @onchange="OnCultureChanged">
    <option value="@CultureConstants.English">English</option>
    <option value="@CultureConstants.Russian">Русский</option>
</select>
````

---

## FILE: `Blazor Web App/Components/Layout/CultureSelector.razor.cs`

````csharp
﻿using Blazor_Web_App.Constants;
using Blazor_Web_App.Services.Culture;
using Microsoft.AspNetCore.Components;

namespace Blazor_Web_App.Components.Layout;

public partial class CultureSelector : ComponentBase
{
    [Inject] public ICultureService CultureService { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;

    private string _current = CultureConstants.Default;

    protected override async Task OnInitializedAsync()
    {
        _current = await CultureService.GetCultureAsync();
        CultureService.Apply(_current);
    }

    private async Task OnCultureChanged(ChangeEventArgs e)
    {
        var next = e.Value?.ToString();

        if (string.IsNullOrEmpty(next) || next == _current)
        {
            return;
        }

        await CultureService.SetCultureAsync(next);

        Nav.NavigateTo(Nav.Uri, forceLoad: true);
    }
}
````

---

## FILE: `Blazor Web App/Components/Layout/MainLayout.razor`

````text
﻿@inherits LayoutComponentBase
@inject IStringLocalizer<SharedResources> Localizer

<div class="page">
    <div class="sidebar">
        <NavMenu />
    </div>

    <main>
        <div class="top-row ps-3 navbar navbar-dark">
            <div class="container-fluid">
                <a class="navbar-brand" href="">Task Marketplace</a>

                <div class="d-flex gap-2 align-items-center">
                    <CultureSelector />
                    <AuthorizeView>
                        <NotAuthorized>
                            <a href="/login" class="btn btn-outline-light btn-sm">
                                @Localizer[ResourceKeys.SignIn]
                            </a>
                        </NotAuthorized>
                    </AuthorizeView>
                </div>
            </div>
        </div>

        <article class="content px-4">
            @Body
        </article>
    </main>
</div>

<div id="blazor-error-ui">
    An unhandled error has occurred.
    <a href="" class="reload">Reload</a>
    <a class="dismiss">🗙</a>
</div>
````

---

## FILE: `Blazor Web App/Components/Layout/MainLayout.razor.cs`

````csharp
﻿using Microsoft.AspNetCore.Components;

namespace Blazor_Web_App.Components.Layout;

public partial class MainLayout : LayoutComponentBase
{

}
````

---

## FILE: `Blazor Web App/Components/Layout/MainLayout.razor.css`

````css
.page {
    position: relative;
    display: flex;
    flex-direction: column;
}

main {
    flex: 1;
}

.sidebar {
    background-image: linear-gradient(180deg, rgb(5, 39, 103) 0%, #3a0647 70%);
}

.top-row {
    background-color: #f7f7f7;
    border-bottom: 1px solid #d6d5d5;
    justify-content: flex-end;
    height: 3.5rem;
    display: flex;
    align-items: center;
}

    .top-row ::deep a, .top-row ::deep .btn-link {
        white-space: nowrap;
        margin-left: 1.5rem;
        text-decoration: none;
    }

    .top-row ::deep a:hover, .top-row ::deep .btn-link:hover {
        text-decoration: underline;
    }

    .top-row ::deep a:first-child {
        overflow: hidden;
        text-overflow: ellipsis;
    }

@media (max-width: 640.98px) {
    .top-row {
        justify-content: space-between;
    }

    .top-row ::deep a, .top-row ::deep .btn-link {
        margin-left: 0;
    }
}

@media (min-width: 641px) {
    .page {
        flex-direction: row;
    }

    .sidebar {
        width: 250px;
        height: 100vh;
        position: sticky;
        top: 0;
    }

    .top-row {
        position: sticky;
        top: 0;
        z-index: 1;
    }

    .top-row.auth ::deep a:first-child {
        flex: 1;
        text-align: right;
        width: 0;
    }

    .top-row, article {
        padding-left: 2rem !important;
        padding-right: 1.5rem !important;
    }
}

#blazor-error-ui {
    color-scheme: light only;
    background: lightyellow;
    bottom: 0;
    box-shadow: 0 -1px 2px rgba(0, 0, 0, 0.2);
    box-sizing: border-box;
    display: none;
    left: 0;
    padding: 0.6rem 1.25rem 0.7rem 1.25rem;
    position: fixed;
    width: 100%;
    z-index: 1000;
}

    #blazor-error-ui .dismiss {
        cursor: pointer;
        position: absolute;
        right: 0.75rem;
        top: 0.5rem;
    }
````

---

## FILE: `Blazor Web App/Components/Layout/NavMenu.razor`

````text
﻿@using global::Shared.Enums
@inject IStringLocalizer<SharedResources> Localizer

<div class="top-row ps-3 navbar navbar-dark">
    <div class="container-fluid">
        <a class="navbar-brand" href="">@Localizer[ResourceKeys.AppName]</a>
        <AuthorizeView>
            <Authorized>
                <button class="btn btn-outline-light btn-sm" @onclick="HandleLogout">
                    @Localizer[ResourceKeys.SignOut]
                </button>
            </Authorized>
            <NotAuthorized>
                <a href="/login" class="btn btn-outline-light btn-sm">
                    @Localizer[ResourceKeys.SignIn]
                </a>
            </NotAuthorized>
        </AuthorizeView>
    </div>
</div>

<input type="checkbox" title="Navigation menu" class="navbar-toggler" />

<div class="nav-scrollable" onclick="document.querySelector('.navbar-toggler').click()">
    <nav class="nav flex-column">
        <AuthorizeView>
            <Authorized Context="AuthContext">
                @if (AuthContext.User.IsInRole(nameof(UserRole.Admin)))
                {
                    <div class="nav-item px-3">
                        <NavLink class="nav-link" href="/admin/users" Match="NavLinkMatch.Prefix">
                            @Localizer[ResourceKeys.AdminUsers]
                        </NavLink>
                    </div>
                    <div class="nav-item px-3">
                        <NavLink class="nav-link" href="/admin/actions" Match="NavLinkMatch.Prefix">
                            @Localizer[ResourceKeys.AdminActions]
                        </NavLink>
                    </div>
                }
                @if (AuthContext.User.IsInRole(nameof(UserRole.Customer)))
                {
                    <div class="nav-item px-3">
                        <NavLink class="nav-link" href="/tasks" Match="NavLinkMatch.Prefix">
                            @Localizer[ResourceKeys.MyTasks]
                        </NavLink>
                    </div>
                }
                @if (AuthContext.User.IsInRole(nameof(UserRole.Executor)))
                {
                    <div class="nav-item px-3">
                        <NavLink class="nav-link" href="/tasks" Match="NavLinkMatch.Prefix">
                            @Localizer[ResourceKeys.BrowseTasks]
                        </NavLink>
                    </div>
                    <div class="nav-item px-3">
                        <NavLink class="nav-link" href="/my-assigned" Match="NavLinkMatch.Prefix">
                            @Localizer[ResourceKeys.MyAssigned]
                        </NavLink>
                    </div>
                }
            </Authorized>
            <NotAuthorized>
                <div class="nav-item px-3">
                    <NavLink class="nav-link" href="/login" Match="NavLinkMatch.Prefix">
                        @Localizer[ResourceKeys.SignIn]
                    </NavLink>
                </div>
            </NotAuthorized>
        </AuthorizeView>
    </nav>
</div>
````

---

## FILE: `Blazor Web App/Components/Layout/NavMenu.razor.cs`

````csharp
﻿using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Components.Layout;

public partial class NavMenu : ComponentBase
{
    [Inject] public ILocalStorageService LocalStorage { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;

    private async Task HandleLogout()
    {
        await LocalStorage.RemoveItemAsync(nameof(AuthDto.Token));
        await LocalStorage.RemoveItemAsync(nameof(AuthDto.Name));
        await LocalStorage.RemoveItemAsync(nameof(AuthDto.Role));
        await LocalStorage.RemoveItemAsync(nameof(AuthDto.Id));

        ((CustomAuthStateProvider)AuthStateProvider).NotifyLogout();

        Nav.NavigateTo("/login");
    }
}
````

---

## FILE: `Blazor Web App/Components/Layout/NavMenu.razor.css`

````css
.navbar-toggler {
    appearance: none;
    cursor: pointer;
    width: 3.5rem;
    height: 2.5rem;
    color: white;
    position: absolute;
    top: 0.5rem;
    right: 1rem;
    border: 1px solid rgba(255, 255, 255, 0.1);
    background: url("data:image/svg+xml,%3csvg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 30 30'%3e%3cpath stroke='rgba%28255, 255, 255, 0.55%29' stroke-linecap='round' stroke-miterlimit='10' stroke-width='2' d='M4 7h22M4 15h22M4 23h22'/%3e%3c/svg%3e") no-repeat center/1.75rem rgba(255, 255, 255, 0.1);
}

.navbar-toggler:checked {
    background-color: rgba(255, 255, 255, 0.5);
}

.top-row {
    min-height: 3.5rem;
    background-color: rgba(0,0,0,0.4);
}

.navbar-brand {
    font-size: 1.1rem;
}

.bi {
    display: inline-block;
    position: relative;
    width: 1.25rem;
    height: 1.25rem;
    margin-right: 0.75rem;
    top: -1px;
    background-size: cover;
}

.bi-house-door-fill-nav-menu {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='white' class='bi bi-house-door-fill' viewBox='0 0 16 16'%3E%3Cpath d='M6.5 14.5v-3.505c0-.245.25-.495.5-.495h2c.25 0 .5.25.5.5v3.5a.5.5 0 0 0 .5.5h4a.5.5 0 0 0 .5-.5v-7a.5.5 0 0 0-.146-.354L13 5.793V2.5a.5.5 0 0 0-.5-.5h-1a.5.5 0 0 0-.5.5v1.293L8.354 1.146a.5.5 0 0 0-.708 0l-6 6A.5.5 0 0 0 1.5 7.5v7a.5.5 0 0 0 .5.5h4a.5.5 0 0 0 .5-.5Z'/%3E%3C/svg%3E");
}

.bi-plus-square-fill-nav-menu {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='white' class='bi bi-plus-square-fill' viewBox='0 0 16 16'%3E%3Cpath d='M2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2zm6.5 4.5v3h3a.5.5 0 0 1 0 1h-3v3a.5.5 0 0 1-1 0v-3h-3a.5.5 0 0 1 0-1h3v-3a.5.5 0 0 1 1 0z'/%3E%3C/svg%3E");
}

.bi-list-nested-nav-menu {
    background-image: url("data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' width='16' height='16' fill='white' class='bi bi-list-nested' viewBox='0 0 16 16'%3E%3Cpath fill-rule='evenodd' d='M4.5 11.5A.5.5 0 0 1 5 11h10a.5.5 0 0 1 0 1H5a.5.5 0 0 1-.5-.5zm-2-4A.5.5 0 0 1 3 7h10a.5.5 0 0 1 0 1H3a.5.5 0 0 1-.5-.5zm-2-4A.5.5 0 0 1 1 3h10a.5.5 0 0 1 0 1H1a.5.5 0 0 1-.5-.5z'/%3E%3C/svg%3E");
}

.nav-item {
    font-size: 0.9rem;
    padding-bottom: 0.5rem;
}

    .nav-item:first-of-type {
        padding-top: 1rem;
    }

    .nav-item:last-of-type {
        padding-bottom: 1rem;
    }

    .nav-item ::deep .nav-link {
        color: #d7d7d7;
        background: none;
        border: none;
        border-radius: 4px;
        height: 3rem;
        display: flex;
        align-items: center;
        line-height: 3rem;
        width: 100%;
    }

.nav-item ::deep a.active {
    background-color: rgba(255,255,255,0.37);
    color: white;
}

.nav-item ::deep .nav-link:hover {
    background-color: rgba(255,255,255,0.1);
    color: white;
}

.nav-scrollable {
    display: none;
}

.navbar-toggler:checked ~ .nav-scrollable {
    display: block;
}

@media (min-width: 641px) {
    .navbar-toggler {
        display: none;
    }

    .nav-scrollable {
        /* Never collapse the sidebar for wide screens */
        display: block;

        /* Allow sidebar to scroll for tall menus */
        height: calc(100vh - 3.5rem);
        overflow-y: auto;
    }
}
````

---

## FILE: `Blazor Web App/Components/Layout/ReconnectModal.razor`

````text
﻿<script type="module" src="@Assets["Components/Layout/ReconnectModal.razor.js"]"></script>

<dialog id="components-reconnect-modal" data-nosnippet>
    <div class="components-reconnect-container">
        <div class="components-rejoining-animation" aria-hidden="true">
            <div></div>
            <div></div>
        </div>
        <p class="components-reconnect-first-attempt-visible">
            Rejoining the server...
        </p>
        <p class="components-reconnect-repeated-attempt-visible">
            Rejoin failed... trying again in <span id="components-seconds-to-next-attempt"></span> seconds.
        </p>
        <p class="components-reconnect-failed-visible">
            Failed to rejoin.<br />Please retry or reload the page.
        </p>
        <button id="components-reconnect-button" class="components-reconnect-failed-visible">
            Retry
        </button>
        <p class="components-pause-visible">
            The session has been paused by the server.
        </p>
        <p class="components-resume-failed-visible">
            Failed to resume the session.<br />Please retry or reload the page.
        </p>
        <button id="components-resume-button" class="components-pause-visible components-resume-failed-visible">
            Resume
        </button>
    </div>
</dialog>
````

---

## FILE: `Blazor Web App/Components/Layout/ReconnectModal.razor.css`

````css
.components-reconnect-first-attempt-visible,
.components-reconnect-repeated-attempt-visible,
.components-reconnect-failed-visible,
.components-pause-visible,
.components-resume-failed-visible,
.components-rejoining-animation {
    display: none;
}

#components-reconnect-modal.components-reconnect-show .components-reconnect-first-attempt-visible,
#components-reconnect-modal.components-reconnect-show .components-rejoining-animation,
#components-reconnect-modal.components-reconnect-paused .components-pause-visible,
#components-reconnect-modal.components-reconnect-resume-failed .components-resume-failed-visible,
#components-reconnect-modal.components-reconnect-retrying,
#components-reconnect-modal.components-reconnect-retrying .components-reconnect-repeated-attempt-visible,
#components-reconnect-modal.components-reconnect-retrying .components-rejoining-animation,
#components-reconnect-modal.components-reconnect-failed,
#components-reconnect-modal.components-reconnect-failed .components-reconnect-failed-visible {
    display: block;
}


#components-reconnect-modal {
    background-color: white;
    width: 20rem;
    margin: 20vh auto;
    padding: 2rem;
    border: 0;
    border-radius: 0.5rem;
    box-shadow: 0 3px 6px 2px rgba(0, 0, 0, 0.3);
    opacity: 0;
    transition: display 0.5s allow-discrete, overlay 0.5s allow-discrete;
    animation: components-reconnect-modal-fadeOutOpacity 0.5s both;
    &[open]

{
    animation: components-reconnect-modal-slideUp 1.5s cubic-bezier(.05, .89, .25, 1.02) 0.3s, components-reconnect-modal-fadeInOpacity 0.5s ease-in-out 0.3s;
    animation-fill-mode: both;
}

}

#components-reconnect-modal::backdrop {
    background-color: rgba(0, 0, 0, 0.4);
    animation: components-reconnect-modal-fadeInOpacity 0.5s ease-in-out;
    opacity: 1;
}

@keyframes components-reconnect-modal-slideUp {
    0% {
        transform: translateY(30px) scale(0.95);
    }

    100% {
        transform: translateY(0);
    }
}

@keyframes components-reconnect-modal-fadeInOpacity {
    0% {
        opacity: 0;
    }

    100% {
        opacity: 1;
    }
}

@keyframes components-reconnect-modal-fadeOutOpacity {
    0% {
        opacity: 1;
    }

    100% {
        opacity: 0;
    }
}

.components-reconnect-container {
    display: flex;
    flex-direction: column;
    align-items: center;
    gap: 1rem;
}

#components-reconnect-modal p {
    margin: 0;
    text-align: center;
}

#components-reconnect-modal button {
    border: 0;
    background-color: #6b9ed2;
    color: white;
    padding: 4px 24px;
    border-radius: 4px;
}

    #components-reconnect-modal button:hover {
        background-color: #3b6ea2;
    }

    #components-reconnect-modal button:active {
        background-color: #6b9ed2;
    }

.components-rejoining-animation {
    position: relative;
    width: 80px;
    height: 80px;
}

    .components-rejoining-animation div {
        position: absolute;
        border: 3px solid #0087ff;
        opacity: 1;
        border-radius: 50%;
        animation: components-rejoining-animation 1.5s cubic-bezier(0, 0.2, 0.8, 1) infinite;
    }

        .components-rejoining-animation div:nth-child(2) {
            animation-delay: -0.5s;
        }

@keyframes components-rejoining-animation {
    0% {
        top: 40px;
        left: 40px;
        width: 0;
        height: 0;
        opacity: 0;
    }

    4.9% {
        top: 40px;
        left: 40px;
        width: 0;
        height: 0;
        opacity: 0;
    }

    5% {
        top: 40px;
        left: 40px;
        width: 0;
        height: 0;
        opacity: 1;
    }

    100% {
        top: 0px;
        left: 0px;
        width: 80px;
        height: 80px;
        opacity: 0;
    }
}
````

---

## FILE: `Blazor Web App/Components/Layout/ReconnectModal.razor.js`

````javascript
// Set up event handlers
const reconnectModal = document.getElementById("components-reconnect-modal");
reconnectModal.addEventListener("components-reconnect-state-changed", handleReconnectStateChanged);

const retryButton = document.getElementById("components-reconnect-button");
retryButton.addEventListener("click", retry);

const resumeButton = document.getElementById("components-resume-button");
resumeButton.addEventListener("click", resume);

function handleReconnectStateChanged(event) {
    if (event.detail.state === "show") {
        reconnectModal.showModal();
    } else if (event.detail.state === "hide") {
        reconnectModal.close();
    } else if (event.detail.state === "failed") {
        document.addEventListener("visibilitychange", retryWhenDocumentBecomesVisible);
    } else if (event.detail.state === "rejected") {
        location.reload();
    }
}

async function retry() {
    document.removeEventListener("visibilitychange", retryWhenDocumentBecomesVisible);

    try {
        // Reconnect will asynchronously return:
        // - true to mean success
        // - false to mean we reached the server, but it rejected the connection (e.g., unknown circuit ID)
        // - exception to mean we didn't reach the server (this can be sync or async)
        const successful = await Blazor.reconnect();
        if (!successful) {
            // We have been able to reach the server, but the circuit is no longer available.
            // We'll reload the page so the user can continue using the app as quickly as possible.
            const resumeSuccessful = await Blazor.resumeCircuit();
            if (!resumeSuccessful) {
                location.reload();
            } else {
                reconnectModal.close();
            }
        }
    } catch (err) {
        // We got an exception, server is currently unavailable
        document.addEventListener("visibilitychange", retryWhenDocumentBecomesVisible);
    }
}

async function resume() {
    try {
        const successful = await Blazor.resumeCircuit();
        if (!successful) {
            location.reload();
        }
    } catch {
        reconnectModal.classList.replace("components-reconnect-paused", "components-reconnect-resume-failed");
    }
}

async function retryWhenDocumentBecomesVisible() {
    if (document.visibilityState === "visible") {
        await retry();
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/Admin/AdminActions.razor`

````text
﻿@page "/admin/actions"

@using Blazor_Web_App.Constants
@using Shared.Enums

<PageTitle>@Localizer[ResourceKeys.UserActions]</PageTitle>

<AuthorizeView Roles="Admin">
    <Authorized>
        <div class="container py-4">
            <h2 class="mb-4">@Localizer[ResourceKeys.UserActions]</h2>

            <div class="row g-2 mb-3">
                <div class="col-md-4">
                    <label class="form-label">@Localizer[ResourceKeys.ActionType]</label>
                    <select class="form-select" @bind="_filterActionType">
                        <option value="">@Localizer[ResourceKeys.All]</option>
                        @foreach (var type in Enum.GetValues<UserActionType>())
                        {
                            <option value="@((int)type)">@type</option>
                        }
                    </select>
                </div>

                <div class="col-md-4 d-flex align-items-end">
                    <button class="btn btn-primary me-2" @onclick="ApplyFilter">@Localizer[ResourceKeys.Apply]</button>
                    <button class="btn btn-secondary" @onclick="ClearFilter">@Localizer[ResourceKeys.Clear]</button>
                </div>
            </div>

            @if (IsLoading)
            {
                <div class="text-center py-5">
                    <div class="spinner-border text-primary"></div>
                </div>
            }
            else if (ErrorMessage != string.Empty)
            {
                <div class="alert alert-danger">@ErrorMessage</div>
            }
            else if (Actions is null || Actions.Count == 0)
            {
                <div class="alert alert-info">@Localizer[ResourceKeys.NoActionsFound]</div>
            }
            else
            {
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>@Localizer[ResourceKeys.User]</th>
                            <th>@Localizer[ResourceKeys.Action]</th>
                            <th>@Localizer[ResourceKeys.Entity]</th>
                            <th>@Localizer[ResourceKeys.When]</th>
                        </tr>
                    </thead>
                    <tbody>
                        @foreach (var action in Actions)
                        {
                            <tr>
                                <td>@action.UserName</td>
                                <td>@action.ActionType</td>
                                <td>@action.EntityType</td>
                                <td>@action.PerformedAt.ToLocalTime().ToString(FormatConstants.ShortDatePattern)</td>
                            </tr>
                        }
                    </tbody>
                </table>

                <nav class="mt-4">
                    <ul class="pagination justify-content-center">
                        <li class="page-item @(CurrentPage <= 1 ? "disabled" : string.Empty)">
                            <button class="page-link" @onclick="() => GoToPage(CurrentPage - 1)">@Localizer[ResourceKeys.Prev]</button>
                        </li>

                        <li class="page-item disabled">
                            <span class="page-link">@CurrentPage / @TotalPages</span>
                        </li>

                        <li class="page-item @(CurrentPage >= TotalPages ? "disabled": string.Empty)">
                            <button class="page-link" @onclick="() => GoToPage(CurrentPage + 1)">@Localizer[ResourceKeys.Next]</button>
                        </li>
                    </ul>
                </nav>
            }
        </div>
    </Authorized>

    <NotAuthorized>
        <div class="container py-4">
            <div class="alert alert-danger">@Localizer[ResourceKeys.AccessDenied]</div>
        </div>
    </NotAuthorized>
</AuthorizeView>
````

---

## FILE: `Blazor Web App/Components/Pages/Admin/AdminActions.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.UserActions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.UserActions;
using Shared.Enums;

namespace Blazor_Web_App.Components.Pages.Admin;

[Authorize(Roles = nameof(UserRole.Admin))]
public partial class AdminActions : ComponentBase
{
    [Inject] public IUserActionService UserActionService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int PageSize = 20;
    private const int FirstPage = 1;

    private List<UserActionDto>? Actions;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private string ErrorMessage = string.Empty;
    private Guid? _filterUserId;
    private int? _filterActionType;

    protected override async Task OnInitializedAsync()
    {
        await LoadActions();
    }

    private async Task LoadActions()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await UserActionService.GetUserActionsAsync(
            _filterUserId,
            _filterActionType,
            CurrentPage,
            PageSize);

        if (result.IsSuccess && result.Value is not null)
        {
            Actions = result.Value.Collection.ToList();
            TotalPages = (int)Math.Ceiling((double)result.Value.TotalCount / PageSize);

            if (TotalPages < FirstPage)
            {
                TotalPages = FirstPage;
            }
        }
        else
        {
            ErrorMessage = result.Message;
            Actions = new List<UserActionDto>();
        }

        IsLoading = false;
    }

    private async Task ApplyFilter()
    {
        CurrentPage = FirstPage;

        await LoadActions();
    }

    private async Task ClearFilter()
    {
        _filterUserId = null;
        _filterActionType = null;
        CurrentPage = FirstPage;

        await LoadActions();
    }

    private async Task GoToPage(int page)
    {
        if (page < FirstPage || page > TotalPages)
        {
            return;
        }

        CurrentPage = page;

        await LoadActions();
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/Admin/AdminUsers.razor`

````text
﻿@page "/admin/users"

@using Blazor_Web_App.Constants
@using Shared.Enums

<PageTitle>@Localizer[ResourceKeys.Users]</PageTitle>

<AuthorizeView Roles="Admin">
    <Authorized>
        <div class="container py-4">
            <h2 class="mb-4">@Localizer[ResourceKeys.Users]</h2>

            @if (IsLoading)
            {
                <div class="text-center py-5">
                    <div class="spinner-border text-primary"></div>
                </div>
            }
            else if (ErrorMessage != string.Empty)
            {
                <div class="alert alert-danger">@ErrorMessage</div>
            }
            else if (Users is null || Users.Count == 0)
            {
                <div class="alert alert-info">@Localizer[ResourceKeys.NoUsersFound]</div>
            }
            else
            {
                <table class="table table-striped align-middle">
                    <thead>
                        <tr>
                            <th>@Localizer[ResourceKeys.Name]</th>
                            <th>@Localizer[ResourceKeys.Role]</th>
                            <th>@Localizer[ResourceKeys.Rating]</th>
                            <th>@Localizer[ResourceKeys.Blocked]</th>
                            <th>@Localizer[ResourceKeys.Actions]</th>
                        </tr>
                    </thead>
                    <tbody>
                        @foreach (var user in Users)
                        {
                            <tr>
                                <td>@user.Name</td>

                                <td>
                                    <select class="form-select form-select-sm"
                                            value="@user.Role"
                                            disabled="@(_processingUserId == user.Id)"
                                            @onchange="e => HandleChangeRole(user.Id, e)">
                                        @foreach (var role in Enum.GetValues<UserRole>().Where(r => r != UserRole.Admin))
                                        {
                                            <option value="@role">@role</option>
                                        }
                                    </select>
                                </td>

                                <td>@(user.Rating?.ToString(FormatConstants.RatingFormat) ?? FormatConstants.EmptyPlaceholder)</td>

                                <td>@(user.IsBlocked ? Localizer[ResourceKeys.Yes].Value : Localizer[ResourceKeys.No].Value)</td>

                                <td>
                                    <button class="btn btn-sm btn-outline-warning me-1"
                                            disabled="@(_processingUserId == user.Id)"
                                            @onclick="() => HandleBlock(user)">
                                        @(user.IsBlocked ? Localizer[ResourceKeys.Unblock].Value : Localizer[ResourceKeys.Block].Value)
                                    </button>

                                    <button class="btn btn-sm btn-outline-danger"
                                            disabled="@(_processingUserId == user.Id)"
                                            @onclick="() => HandleDelete(user.Id)">
                                        @Localizer[ResourceKeys.Delete]
                                    </button>
                                </td>
                            </tr>
                        }
                    </tbody>
                </table>

                <nav class="mt-4">
                    <ul class="pagination justify-content-center">
                        <li class="page-item @(CurrentPage <= 1 ? "disabled": string.Empty)">
                            <button class="page-link" @onclick="() => GoToPage(CurrentPage - 1)">@Localizer[ResourceKeys.Prev]</button>
                        </li>

                        <li class="page-item disabled">
                            <span class="page-link">@CurrentPage / @TotalPages</span>
                        </li>

                        <li class="page-item @(CurrentPage >= TotalPages ? "disabled" : string.Empty)">
                            <button class="page-link" @onclick="() => GoToPage(CurrentPage + 1)">@Localizer[ResourceKeys.Next]</button>
                        </li>
                    </ul>
                </nav>
            }
        </div>
    </Authorized>

    <NotAuthorized>
        <div class="container py-4">
            <div class="alert alert-danger">@Localizer[ResourceKeys.AccessDenied]</div>
        </div>
    </NotAuthorized>
</AuthorizeView>
````

---

## FILE: `Blazor Web App/Components/Pages/Admin/AdminUsers.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Blazor_Web_App.Components.Pages.Admin;

[Authorize(Roles = nameof(UserRole.Admin))]
public partial class AdminUsers : ComponentBase
{
    [Inject] public IUserService UserService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int PageSize = 10;
    private const int FirstPage = 1;

    private List<UserDto>? Users;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private string ErrorMessage = string.Empty;
    private Guid _processingUserId;

    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
    }

    private async Task LoadUsers()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await UserService.GetUsersAsync(CurrentPage, PageSize);

        if (result.IsSuccess && result.Value is not null)
        {
            Users = result.Value.Collection.ToList();
            TotalPages = (int)Math.Ceiling((double)result.Value.TotalCount / PageSize);

            if (TotalPages < FirstPage)
            {
                TotalPages = FirstPage;
            }
        }
        else
        {
            ErrorMessage = result.Message;
            Users = new List<UserDto>();
        }

        IsLoading = false;
    }

    private async Task GoToPage(int page)
    {
        if (page < FirstPage || page > TotalPages)
        {
            return;
        }

        CurrentPage = page;

        await LoadUsers();
    }

    private async Task HandleChangeRole(Guid userId, ChangeEventArgs e)
    {
        if (!Enum.TryParse<UserRole>(e.Value?.ToString(), out var role))
        {
            return;
        }

        _processingUserId = userId;

        var result = await UserService.ChangeRoleAsync(userId, role);

        if (result.IsSuccess)
        {
            await LoadUsers();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        _processingUserId = Guid.Empty;
    }

    private async Task HandleBlock(UserDto user)
    {
        _processingUserId = user.Id;

        var result = user.IsBlocked
            ? await UserService.UnblockUserAsync(user.Id)
            : await UserService.BlockUserAsync(user.Id);

        if (result.IsSuccess)
        {
            await LoadUsers();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        _processingUserId = Guid.Empty;
    }

    private async Task HandleDelete(Guid userId)
    {
        _processingUserId = userId;

        var result = await UserService.DeleteUserAsync(userId);

        if (result.IsSuccess)
        {
            await LoadUsers();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        _processingUserId = Guid.Empty;
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/Auth/Login.razor`

````text
﻿@page "/login"

<PageTitle>@Localizer[ResourceKeys.Login]</PageTitle>

<div class="d-flex flex-column min-vh-100 justify-content-center align-items-center">
    <div class="card p-4" style="width: 40rem;">
        <h3 class="text-center mb-4">@Localizer[ResourceKeys.Login]</h3>

        @if (!IsSuccess)
        {
            @if (!string.IsNullOrEmpty(ErrorMessage))
            {
                <div class="alert alert-danger">@ErrorMessage</div>
            }

            <input class="form-control mb-3" type="text" placeholder="@Localizer[ResourceKeys.Login]" @bind="Name" />

            <input class="form-control mb-3" type="password" placeholder="@Localizer[ResourceKeys.Password]" @bind="Password" />

            <button class="btn btn-primary w-100" @onclick="HandleLogin" disabled="@IsLoading">
                @(IsLoading ? Localizer[ResourceKeys.Loading].Value : Localizer[ResourceKeys.SignIn].Value)
            </button>

            <div class="text-center mt-3">
                <a href="/register" class="text-decoration-none">@Localizer[ResourceKeys.NoAccount]</a>
            </div>
        }
        else
        {
            <div class="alert alert-success text-center">@Localizer[ResourceKeys.LoggedInSuccess]</div>
        }
    </div>
</div>
````

---

## FILE: `Blazor Web App/Components/Pages/Auth/Login.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Blazor_Web_App.Services.Receivers.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Components.Pages.Auth;

[AllowAnonymous]
public partial class Login : ComponentBase
{
    [Inject] public IAuthService AuthService { get; set; } = null!;
    [Inject] public ILocalStorageService LocalStorageService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const string IndexUri = "/";

    protected string Name { get; set; } = string.Empty;

    protected string Password { get; set; } = string.Empty;

    protected string ErrorMessage { get; set; } = string.Empty;

    protected bool IsSuccess { get; set; }

    protected bool IsLoading { get; set; }

    public async Task HandleLogin()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var loginDto = new LoginDto(Name, Password);
        var result = await AuthService.LoginAsync(loginDto);

        if (result.IsSuccess)
        {
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Token), result.Value!.Token);
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Name), result.Value.Name);
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Role), result.Value.Role.ToString());
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Id), result.Value.Id.ToString());

            ((CustomAuthStateProvider)AuthStateProvider).NotifyLogin(
                result.Value.Name,
                result.Value.Role.ToString(),
                result.Value.Id.ToString());

            NavigationManager.NavigateTo(IndexUri);
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsLoading = false;
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/Auth/RedirectToLogin.razor`

````text
﻿@page "/redirect-to-login"
````

---

## FILE: `Blazor Web App/Components/Pages/Auth/RedirectToLogin.razor.cs`

````csharp
﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace Blazor_Web_App.Components.Pages.Auth;

[AllowAnonymous]
public partial class RedirectToLogin : ComponentBase
{
    [Inject] public NavigationManager Navigation { get; set; } = null!;

    private const bool IsForceNavigate = true;

    protected override void OnInitialized()
    {
        Navigation.NavigateTo("/login", IsForceNavigate);
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/Auth/Register.razor`

````text
﻿@page "/register"

@using Shared.Enums

<PageTitle>@Localizer[ResourceKeys.Register]</PageTitle>

<div class="d-flex flex-column min-vh-100 justify-content-center align-items-center">
    <div class="card p-4" style="width: 40rem;">
        <h3 class="text-center mb-4">@Localizer[ResourceKeys.Register]</h3>

        @if (!IsSuccess)
        {
            @if (!string.IsNullOrEmpty(ErrorMessage))
            {
                <div class="alert alert-danger">
                    @ErrorMessage
                </div>
            }

            <input class="form-control mb-3"
                   type="text"
                   placeholder="@Localizer[ResourceKeys.Login]"
                   @bind="Login" />

            <input class="form-control mb-3"
                   type="password"
                   placeholder="@Localizer[ResourceKeys.Password]"
                   @bind="Password" />

            <select class="form-select mb-3" @bind="Role">
                <option value="@UserRole.Customer">@Localizer[ResourceKeys.Customer]</option>
                <option value="@UserRole.Executor">@Localizer[ResourceKeys.Executor]</option>
            </select>

            <button class="btn btn-primary w-100"
                    @onclick="HandleRegister"
                    disabled="@IsLoading">
                @(IsLoading ? Localizer[ResourceKeys.Loading].Value : Localizer[ResourceKeys.Register].Value)
            </button>
        }
        else
        {
            <div class="alert alert-success text-center">
                @Localizer[ResourceKeys.RegisteredSuccess]
            </div>
        }
    </div>
</div>
````

---

## FILE: `Blazor Web App/Components/Pages/Auth/Register.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services;
using Blazor_Web_App.Services.LocalStorage;
using Blazor_Web_App.Services.Receivers.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Blazor_Web_App.Components.Pages.Auth;

[AllowAnonymous]
public partial class Register : ComponentBase
{
    [Inject] public IAuthService AuthService { get; set; } = null!;
    [Inject] public ILocalStorageService LocalStorageService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager NavigationManager { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const string IndexUri = "/";

    protected string Login { get; set; } = string.Empty;

    protected string Password { get; set; } = string.Empty;

    protected UserRole Role { get; set; } = UserRole.Customer;

    protected string ErrorMessage { get; set; } = string.Empty;

    protected bool IsSuccess { get; set; }

    protected bool IsLoading { get; set; }

    public async Task HandleRegister()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var registerUserDto = new RegisterUserDto(Login, Password, Role);

        var registerResult = await AuthService.RegisterAsync(registerUserDto);

        if (registerResult.IsSuccess)
        {
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Token), registerResult.Value!.Token);
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Name), registerResult.Value!.Name);
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Role), registerResult.Value!.Role.ToString());
            await LocalStorageService.SetItemAsync(nameof(AuthDto.Id), registerResult.Value.Id.ToString());

            ((CustomAuthStateProvider)AuthStateProvider).NotifyLogin(
                registerResult.Value!.Name,
                registerResult.Value!.Role,
                registerResult.Value.Id.ToString());

            NavigationManager.NavigateTo(IndexUri);
        }
        else
        {
            ErrorMessage = registerResult.Message;
        }

        IsSuccess = registerResult.IsSuccess;
        IsLoading = false;
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/Errors/Error.razor`

````text
﻿@page "/Error"

@using System.Diagnostics

@attribute [AllowAnonymous]

<PageTitle>Error</PageTitle>

<h1 class="text-danger">Error.</h1>
<h2 class="text-danger">An error occurred while processing your request.</h2>

@if (ShowRequestId)
{
    <p>
        <strong>Request ID:</strong> <code>@RequestId</code>
    </p>
}

<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>

@code{
    [CascadingParameter]
    private HttpContext? HttpContext { get; set; }

    private string? RequestId { get; set; }
    private bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    protected override void OnInitialized() =>
        RequestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
}
````

---

## FILE: `Blazor Web App/Components/Pages/Errors/NotFound.razor`

````text
﻿@page "/not-found"

@attribute [AllowAnonymous]

@layout MainLayout

<h3>Not Found</h3>
<p>Sorry, the content you are looking for does not exist.</p>
````

---

## FILE: `Blazor Web App/Components/Pages/Executor/MyAssignedTasks.razor`

````text
﻿@page "/my-assigned"

<PageTitle>@Localizer[ResourceKeys.MyAssignedTasks]</PageTitle>

<div class="container py-4">
    <h2 class="mb-4">@Localizer[ResourceKeys.MyAssignedTasks]</h2>

    @if (IsLoading)
    {
        <div class="spinner-border text-primary"></div>
    }
    else if (ErrorMessage != string.Empty)
    {
        <div class="alert alert-danger">@ErrorMessage</div>
    }
    else if (ListTasks is null || ListTasks.Count == 0)
    {
        <div class="alert alert-info">@Localizer[ResourceKeys.NoAssignedTasks]</div>
    }
    else
    {
        <div class="row g-3">
            @foreach (var task in ListTasks)
            {
                <div class="col-md-6 col-lg-4">
                    <TaskCard ProjectTask="task"
                              CurrentUserId="CurrentUserId"
                              IsExecutor="true"
                              IsCustomer="false"
                              IsResponded="true"
                              OnOpenChat="OpenChatModal"
                              OnOpenAttachments="OpenAttachmentsModal" />
                </div>
            }
        </div>

        <nav class="mt-4">
            <ul class="pagination justify-content-center">
                <li class="page-item @(CurrentPage <= 1 ? "disabled" : string.Empty)">
                    <button class="page-link" @onclick="() => GoToPage(CurrentPage - 1)">@Localizer[ResourceKeys.Prev]</button>
                </li>

                <li class="page-item disabled">
                    <span class="page-link">@CurrentPage / @TotalPages</span>
                </li>

                <li class="page-item @(CurrentPage >= TotalPages ? "disabled" : string.Empty)">
                    <button class="page-link" @onclick="() => GoToPage(CurrentPage + 1)">@Localizer[ResourceKeys.Next]</button>
                </li>
            </ul>
        </nav>
    }
</div>

<ChatModal IsVisible="IsChatModalOpen"
           TaskId="_chatTaskId"
           CurrentUserId="CurrentUserId"
           OnClose="() => IsChatModalOpen = false" />

<AttachmentsModal IsVisible="_attachmentsModal.IsOpen"
                  TaskId="_attachmentsModal.TaskId"
                  CurrentUserId="CurrentUserId"
                  CanUpload="@ComputeCanUpload()"
                  OnClose="_attachmentsModal.Close" />
````

---

## FILE: `Blazor Web App/Components/Pages/Executor/MyAssignedTasks.razor.cs`

````csharp
﻿using Blazor_Web_App.Modals;
using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;

namespace Blazor_Web_App.Components.Pages.Executor;

[Authorize]
public partial class MyAssignedTasks : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int PageSize = 10;
    private const int FirstPage = 1;
    private const string LoginUri = "/login";

    private List<ProjectTaskDto>? ListTasks;
    private Guid CurrentUserId;
    private Guid _chatTaskId;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private bool IsChatModalOpen;
    private bool _initialized;
    private string ErrorMessage = string.Empty;
    private readonly ModalState _attachmentsModal = new();
    private ProjectTaskDto? _attachmentsModalTask;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender || _initialized)
        {
            return;
        }

        _initialized = true;

        var state = await AuthStateProvider.GetAuthenticationStateAsync();

        if (!state.User.Identity?.IsAuthenticated ?? true)
        {
            Nav.NavigateTo(LoginUri);
            return;
        }

        var idClaim = state.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (!Guid.TryParse(idClaim, out var userId))
        {
            Nav.NavigateTo(LoginUri);
            return;
        }

        CurrentUserId = userId;

        await LoadTasks();

        StateHasChanged();
    }

    private void OpenAttachmentsModal(Guid taskId)
    {
        _attachmentsModalTask = ListTasks?.FirstOrDefault(t => t.Id == taskId);
        _attachmentsModal.Open(taskId);
    }

    private bool ComputeCanUpload()
    {
        if (_attachmentsModalTask is null)
        {
            return false;
        }

        var isParticipant = _attachmentsModalTask.CustomerId == CurrentUserId
                            || _attachmentsModalTask.ExecutorId == CurrentUserId;

        var isOpen = _attachmentsModalTask.Status != ProjectTaskStatus.Done
                  && _attachmentsModalTask.Status != ProjectTaskStatus.Cancelled;

        return isParticipant && isOpen;
    }

    private async Task LoadTasks()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await ProjectTaskService.GetAssignedTasksAsync(CurrentUserId, CurrentPage, PageSize);

        if (result.IsSuccess && result.Value is not null)
        {
            ListTasks = result.Value.Collection.ToList();
            TotalPages = (int)Math.Ceiling((double)result.Value.TotalCount / PageSize);

            if (TotalPages < FirstPage)
            {
                TotalPages = FirstPage;
            }
        }
        else
        {
            ErrorMessage = result.Message;
            ListTasks = new List<ProjectTaskDto>();
        }

        IsLoading = false;
    }

    private async Task GoToPage(int page)
    {
        if (page < FirstPage || page > TotalPages)
        {
            return;
        }

        CurrentPage = page;

        await LoadTasks();
    }

    private void OpenChatModal(Guid taskId)
    {
        _chatTaskId = taskId;
        IsChatModalOpen = true;
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/Home.razor`

````text
﻿@page "/"

@using Shared.Enums
@using System.Security.Claims

<PageTitle>@Localizer[ResourceKeys.AppName]</PageTitle>

<div class="container py-5">
    <AuthorizeView>
        <Authorized Context="AuthContext">
            @{
                var userName = AuthContext.User.Identity?.Name ?? "User";
                var role = AuthContext.User.FindFirst(ClaimTypes.Role)?.Value ?? "Unknown";
            }

            <div class="p-5 mb-4 bg-light rounded-3 border">
                <div class="container-fluid py-2">
                    <h1 class="display-5 fw-bold mb-2">@Localizer[ResourceKeys.AppName]</h1>

                    <div class="d-flex align-items-center gap-3">
                        <span class="fs-5">@Localizer[ResourceKeys.Hello], <strong>@userName</strong></span>
                        <span class="badge bg-primary fs-6">@role</span>
                    </div>
                </div>
            </div>

            <h2 class="h4 mb-3">@Localizer[ResourceKeys.QuickActions]</h2>

            <div class="row g-3">
                @if (AuthContext.User.IsInRole(nameof(UserRole.Customer)))
                {
                    <div class="col-md-6 col-lg-4">
                        <div class="card h-100 shadow-sm">
                            <div class="card-body d-flex flex-column">
                                <h5 class="card-title">@Localizer[ResourceKeys.MyTasks]</h5>
                                <p class="card-text text-muted">@Localizer[ResourceKeys.ManageMyTasks]</p>
                                <a class="btn btn-primary mt-auto" href="/tasks">@Localizer[ResourceKeys.OpenTasks]</a>
                            </div>
                        </div>
                    </div>
                }

                @if (AuthContext.User.IsInRole(nameof(UserRole.Executor)))
                {
                    <div class="col-md-6 col-lg-4">
                        <div class="card h-100 shadow-sm">
                            <div class="card-body d-flex flex-column">
                                <h5 class="card-title">@Localizer[ResourceKeys.BrowseTasks]</h5>
                                <p class="card-text text-muted">@Localizer[ResourceKeys.FindTasks]</p>
                                <a class="btn btn-primary mt-auto" href="/tasks">@Localizer[ResourceKeys.Browse]</a>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-6 col-lg-4">
                        <div class="card h-100 shadow-sm">
                            <div class="card-body d-flex flex-column">
                                <h5 class="card-title">@Localizer[ResourceKeys.MyAssignedTasks]</h5>
                                <p class="card-text text-muted">@Localizer[ResourceKeys.TasksAssigned]</p>
                                <a class="btn btn-primary mt-auto" href="/my-assigned">@Localizer[ResourceKeys.OpenAssigned]</a>
                            </div>
                        </div>
                    </div>
                }

                @if (AuthContext.User.IsInRole(nameof(UserRole.Admin)))
                {
                    <div class="col-md-6 col-lg-4">
                        <div class="card h-100 shadow-sm">
                            <div class="card-body d-flex flex-column">
                                <h5 class="card-title">@Localizer[ResourceKeys.AdminUsers]</h5>
                                <p class="card-text text-muted">@Localizer[ResourceKeys.ManageUsers]</p>
                                <a class="btn btn-primary mt-auto" href="/admin/users">@Localizer[ResourceKeys.OpenUsers]</a>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-6 col-lg-4">
                        <div class="card h-100 shadow-sm">
                            <div class="card-body d-flex flex-column">
                                <h5 class="card-title">@Localizer[ResourceKeys.AdminActions]</h5>
                                <p class="card-text text-muted">@Localizer[ResourceKeys.ViewLog]</p>
                                <a class="btn btn-primary mt-auto" href="/admin/actions">@Localizer[ResourceKeys.OpenLog]</a>
                            </div>
                        </div>
                    </div>
                }
            </div>
        </Authorized>

        <NotAuthorized>
            <div class="p-5 mb-4 bg-light rounded-3 border text-center">
                <h1 class="display-5 fw-bold mb-3">@Localizer[ResourceKeys.AppName]</h1>

                <div class="d-flex justify-content-center gap-2">
                    <a class="btn btn-primary btn-lg" href="/login">@Localizer[ResourceKeys.SignIn]</a>
                    <a class="btn btn-outline-secondary btn-lg" href="/register">@Localizer[ResourceKeys.Register]</a>
                </div>
            </div>
        </NotAuthorized>
    </AuthorizeView>
</div>
````

---

## FILE: `Blazor Web App/Components/Pages/Home.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Blazor_Web_App.Components.Pages;

[AllowAnonymous]
public partial class Home : ComponentBase
{
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;
}
````

---

## FILE: `Blazor Web App/Components/Pages/Tasks.razor`

````text
﻿@page "/tasks"

@using Blazor_Web_App.Components.Pages.TasksModals
@using Blazor_Web_App.Constants
@using Shared.Enums

<PageTitle>@Localizer[PageTitleTextKey]</PageTitle>

<div class="container py-4">
    <div class="d-flex justify-content-between align-items-center mb-4">
        <h2>@Localizer[PageTitleTextKey]</h2>

        @if (IsCustomer)
        {
            <button class="btn btn-primary" @onclick="ShowCreateModal">@Localizer[ResourceKeys.NewTask]</button>
        }
    </div>

    <div class="d-flex gap-2 mb-3">
        <input class="form-control" placeholder="@Localizer[ResourceKeys.SearchPlaceholder]" @bind="_searchQuery" />
        <button class="btn btn-primary" @onclick="HandleSearch">@Localizer[ResourceKeys.Search]</button>
        <button class="btn btn-secondary" @onclick="ClearSearch">@Localizer[ResourceKeys.Clear]</button>
    </div>

    @if (IsLoading)
    {
        <div class="text-center py-5">
            <div class="spinner-border text-primary"></div>
        </div>
    }
    else if (ErrorMessage != string.Empty)
    {
        <div class="alert alert-danger">@ErrorMessage</div>
    }
    else if (ListTasks is null || ListTasks.Count == 0)
    {
        <div class="alert alert-info text-center">@Localizer[ResourceKeys.NoTasksFound]</div>
    }
    else
    {
        <div class="row g-3">
            @foreach (var task in ListTasks)
            {
                <div class="col-md-6 col-lg-4">
                    <div class="d-flex flex-column h-100">
                        <TaskCard ProjectTask="task"
                                  CurrentUserId="CurrentUserId"
                                  IsExecutor="IsExecutor"
                                  IsCustomer="IsCustomer"
                                  IsResponded="task.IsRespondedByCurrentUser"
                                  OnDeleted="HandleTaskDeleted"
                                  OnRespond="HandleRespond"
                                  OnOpenChat="OpenChatModal"
                                  OnOpenAttachments="OpenAttachmentsModal"
                                  OnMarkDone="OpenRateModal"
                                  OnCancel="HandleCancel"
                                  OnEdit="OpenEditModal" />

                        @if (IsCustomer && task.Status == ProjectTaskStatus.Published)
                        {
                            <button class="btn btn-sm btn-outline-primary w-100 mt-2"
                                    @onclick="() => OpenResponsesModal(task.Id, task.Title)">
                                @Localizer[ResourceKeys.ViewCandidates]
                            </button>
                        }
                    </div>
                </div>
            }
        </div>

        <nav class="mt-4 mb-5">
            <ul class="pagination justify-content-center">
                <li class="page-item @(CurrentPage <= 1 ? "disabled" : string.Empty)">
                    <button class="page-link" @onclick="() => GoToPage(CurrentPage - 1)">@Localizer[ResourceKeys.Prev]</button>
                </li>

                <li class="page-item disabled">
                    <span class="page-link">@CurrentPage / @TotalPages</span>
                </li>

                <li class="page-item @(CurrentPage >= TotalPages ? "disabled" : string.Empty)">
                    <button class="page-link" @onclick="() => GoToPage(CurrentPage + 1)">@Localizer[ResourceKeys.Next]</button>
                </li>
            </ul>
        </nav>
    }
</div>

@if (IsCustomer)
{
    <CreateTaskModal IsVisible="_createModal.IsOpen"
                     OnCreated="HandleTaskCreated"
                     OnClose="_createModal.Close" />
}

<ResponsesModal IsVisible="_responsesModal.IsOpen"
                TaskId="_responsesModal.TaskId"
                OnAssigned="HandleTaskCreated"
                OnClose="_responsesModal.Close" />

<ChatModal IsVisible="_chatModal.IsOpen"
           TaskId="_chatModal.TaskId"
           CurrentUserId="CurrentUserId"
           OnClose="_chatModal.Close" />

<RateExecutorModal IsVisible="_rateModal.IsOpen"
                   TaskId="_rateModal.TaskId"
                   OnCompleted="HandleRated"
                   OnClose="_rateModal.Close" />

<EditTaskModal IsVisible="_editModal.IsOpen"
               Task="_editingTask"
               OnUpdated="HandleTaskUpdated"
               OnClose="_editModal.Close" />

<AttachmentsModal IsVisible="_attachmentsModal.IsOpen"
                  TaskId="_attachmentsModal.TaskId"
                  CurrentUserId="CurrentUserId"
                  CanUpload="@ComputeCanUpload()"
                  OnClose="_attachmentsModal.Close" />
````

---

## FILE: `Blazor Web App/Components/Pages/Tasks.razor.cs`

````csharp
﻿using Blazor_Web_App.Modals;
using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;

namespace Blazor_Web_App.Components.Pages;

[Authorize]
public partial class Tasks : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public AuthenticationStateProvider AuthStateProvider { get; set; } = null!;
    [Inject] public NavigationManager Nav { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int PageSize = 10;
    private const int FirstPage = 1;
    private const string LoginUri = "/login";

    private readonly ModalState _createModal = new();
    private readonly ModalState _responsesModal = new();
    private readonly ModalState _chatModal = new();
    private readonly ModalState _rateModal = new();
    private readonly ModalState _editModal = new();
    private readonly ModalState _attachmentsModal = new();

    private List<ProjectTaskDto>? ListTasks;
    private Guid CurrentUserId;
    private int CurrentPage = FirstPage;
    private int TotalPages = FirstPage;
    private bool IsLoading;
    private bool IsCustomer;
    private bool IsExecutor;
    private bool _initialized;
    private string ErrorMessage = string.Empty;
    private string PageTitleTextKey = ResourceKeys.MyTasks;
    private string _searchQuery = string.Empty;
    private ProjectTaskDto? _editingTask;
    private ProjectTaskDto? _attachmentsModalTask;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender || _initialized)
        {
            return;
        }

        _initialized = true;

        var state = await AuthStateProvider.GetAuthenticationStateAsync();

        if (!state.User.Identity?.IsAuthenticated ?? true)
        {
            Nav.NavigateTo(LoginUri);
            return;
        }

        var idClaim = state.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (!Guid.TryParse(idClaim, out var userId))
        {
            Nav.NavigateTo(LoginUri);
            return;
        }

        IsCustomer = state.User.IsInRole(nameof(UserRole.Customer));
        IsExecutor = state.User.IsInRole(nameof(UserRole.Executor));
        PageTitleTextKey = IsCustomer ? ResourceKeys.MyTasks : ResourceKeys.AvailableTasks;
        CurrentUserId = userId;

        await LoadTasks();

        StateHasChanged();
    }

    private void OpenAttachmentsModal(Guid taskId)
    {
        _attachmentsModalTask = ListTasks?.FirstOrDefault(t => t.Id == taskId);
        _attachmentsModal.Open(taskId);
    }

    private bool ComputeCanUpload()
    {
        if (_attachmentsModalTask is null)
        {
            return false;
        }

        var isParticipant = _attachmentsModalTask.CustomerId == CurrentUserId
                            || _attachmentsModalTask.ExecutorId == CurrentUserId;

        var isOpen = _attachmentsModalTask.Status != ProjectTaskStatus.Done
                  && _attachmentsModalTask.Status != ProjectTaskStatus.Cancelled;

        return isParticipant && isOpen;
    }

    private async Task LoadTasks()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        Result<PagedResult<ProjectTaskDto>> result;

        if (!string.IsNullOrWhiteSpace(_searchQuery))
        {
            result = await ProjectTaskService.SearchTasksAsync(_searchQuery, CurrentPage, PageSize);
        }
        else if (IsCustomer)
        {
            result = await ProjectTaskService.GetMyTasksAsync(CurrentUserId, CurrentPage, PageSize);
        }
        else if (IsExecutor)
        {
            result = await ProjectTaskService.GetPublishedTasksAsync(CurrentPage, PageSize);
        }
        else
        {
            result = await ProjectTaskService.GetPublishedTasksAsync(CurrentPage, PageSize);
        }

        if (result.IsSuccess && result.Value is not null)
        {
            ListTasks = result.Value.Collection.ToList();
            TotalPages = (int)Math.Ceiling((double)result.Value.TotalCount / PageSize);

            if (TotalPages < FirstPage)
            {
                TotalPages = FirstPage;
            }
        }
        else
        {
            ErrorMessage = result.Message;
            ListTasks = new List<ProjectTaskDto>();
        }

        IsLoading = false;
    }

    private async Task HandleRespond(Guid taskId)
    {
        var result = await ProjectTaskService.RespondToTaskAsync(taskId);

        if (result.IsSuccess)
        {
            await LoadTasks();
        }
        else
        {
            ErrorMessage = result.Message;
        }
    }

    private async Task HandleTaskCreated()
    {
        CurrentPage = FirstPage;
        await LoadTasks();
    }

    private async Task HandleTaskDeleted(Guid taskId)
    {
        await LoadTasks();
    }

    private async Task HandleCancel(Guid taskId)
    {
        var result = await ProjectTaskService.CancelTaskAsync(taskId);

        if (result.IsSuccess)
        {
            await LoadTasks();
        }
        else
        {
            ErrorMessage = result.Message;
        }
    }

    private async Task HandleRated()
    {
        _rateModal.Close();
        await LoadTasks();
    }

    private async Task GoToPage(int page)
    {
        if (page < FirstPage || page > TotalPages)
        {
            return;
        }

        CurrentPage = page;

        await LoadTasks();
    }

    private void OpenResponsesModal(Guid taskId, string title)
    {
        _responsesModal.Open(taskId, title);
    }

    private void OpenChatModal(Guid taskId)
    {
        _chatModal.Open(taskId);
    }

    private void OpenRateModal(Guid taskId)
    {
        _rateModal.Open(taskId);
    }

    private void ShowCreateModal()
    {
        _createModal.Open(Guid.Empty);
    }

    private async Task HandleSearch()
    {
        CurrentPage = FirstPage;
        await LoadTasks();
    }

    private async Task ClearSearch()
    {
        _searchQuery = string.Empty;
        CurrentPage = FirstPage;
        await LoadTasks();
    }

    private void OpenEditModal(Guid taskId)
    {
        _editingTask = ListTasks?.FirstOrDefault(t => t.Id == taskId);

        if (_editingTask is null)
        {
            return;
        }

        _editModal.Open(taskId);
    }

    private async Task HandleTaskUpdated()
    {
        _editModal.Close();

        await LoadTasks();
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/AttachmentsModal.razor`

````text
﻿@using Blazor_Web_App.Constants
@using Microsoft.AspNetCore.Components.Forms

@if (IsVisible)
{
    <div class="modal fade show d-block" style="background: rgba(0,0,0,0.5);">
        <div class="modal-dialog modal-dialog-centered modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">@Localizer[ResourceKeys.Attachments]: @TaskTitle</h5>
                    <button class="btn-close" @onclick="Close"></button>
                </div>

                <div class="modal-body">
                    @if (ErrorMessage != string.Empty)
                    {
                        <div class="alert alert-danger">@ErrorMessage</div>
                    }

                    @if (CanUpload)
                    {
                        <div class="mb-3">
                            <label class="form-label">
                                @Localizer[ResourceKeys.UploadFile]
                                @string.Format(Localizer[ResourceKeys.MaxSizeLabel], MaxSizeMb)
                            </label>
                            <InputFile class="form-control"
                                       OnChange="HandleFileSelected"
                                       disabled="@IsUploading" />

                            @if (IsUploading)
                            {
                                <div class="spinner-border spinner-border-sm text-primary mt-2"></div>
                            }
                        </div>
                    }

                    @if (IsLoading)
                    {
                        <div class="text-center py-3">
                            <div class="spinner-border text-primary"></div>
                        </div>
                    }
                    else if (Attachments is null || Attachments.Count == 0)
                    {
                        <div class="alert alert-info">@Localizer[ResourceKeys.NoAttachments]</div>
                    }
                    else
                    {
                        <ul class="list-group">
                            @foreach (var a in Attachments)
                            {
                                <li class="list-group-item d-flex justify-content-between align-items-center">
                                    <div class="text-truncate me-2">
                                        <strong>@a.OriginalFileName</strong>
                                        <br />
                                        <small class="text-muted">
                                            @FormatSize(a.SizeBytes) — @a.UploadedAt.ToLocalTime().ToString(FormatConstants.ShortDatePattern)
                                        </small>
                                    </div>

                                    <div class="d-flex gap-1">
                                        <button class="btn btn-sm btn-outline-primary"
                                                @onclick="() => Download(a)">
                                            @Localizer[ResourceKeys.Download]
                                        </button>

                                        @if (a.UploadedByUserId == CurrentUserId)
                                        {
                                            <button class="btn btn-sm btn-outline-danger"
                                                    @onclick="() => Delete(a)"
                                                    disabled="@IsDeleting">
                                                @Localizer[ResourceKeys.Delete]
                                            </button>
                                        }
                                    </div>
                                </li>
                            }
                        </ul>
                    }
                </div>

                <div class="modal-footer">
                    <button class="btn btn-secondary" @onclick="Close">
                        @Localizer[ResourceKeys.Close]
                    </button>
                </div>
            </div>
        </div>
    </div>
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/AttachmentsModal.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Blazor_Web_App.Services.Receivers.TaskAttachments;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class AttachmentsModal : ComponentBase
{
    [Inject] public ITaskAttachmentService TaskAttachmentService { get; set; } = null!;
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;
    [Inject] public IJSRuntime JS { get; set; } = null!;

    private const long MaxSizeBytes = 50L * 1024 * 1024;
    private const int MaxSizeMb = (int)(MaxSizeBytes / (1024 * 1024));

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public Guid TaskId { get; set; }

    [Parameter] public Guid CurrentUserId { get; set; }

    [Parameter] public bool CanUpload { get; set; } = true;

    [Parameter] public EventCallback OnClose { get; set; }

    private List<TaskAttachmentDto>? Attachments;
    private string TaskTitle = string.Empty;
    private string ErrorMessage = string.Empty;
    private bool IsLoading;
    private bool IsUploading;
    private bool IsDeleting;

    protected override async Task OnParametersSetAsync()
    {
        if (!IsVisible || TaskId == Guid.Empty)
        {
            return;
        }

        await LoadTitle();
        await LoadAttachments();
    }

    private async Task LoadTitle()
    {
        var result = await ProjectTaskService.GetTaskByIdAsync(TaskId);

        if (result.IsSuccess && result.Value is not null)
        {
            TaskTitle = result.Value.Title;
        }
    }

    private async Task LoadAttachments()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await TaskAttachmentService.GetTaskAttachmentsAsync(TaskId);

        if (result.IsSuccess && result.Value is not null)
        {
            Attachments = result.Value;
        }
        else
        {
            ErrorMessage = result.Message ?? "Failed to load attachments";
            Attachments = new List<TaskAttachmentDto>();
        }

        IsLoading = false;
    }

    private async Task HandleFileSelected(InputFileChangeEventArgs e)
    {
        ErrorMessage = string.Empty;

        var file = e.File;

        if (file is null)
        {
            return;
        }

        if (file.Size > MaxSizeBytes)
        {
            ErrorMessage = $"File size exceeds the allowed limit of {MaxSizeMb} MB.";
            return;
        }

        IsUploading = true;

        try
        {
            await using var stream = file.OpenReadStream(MaxSizeBytes);

            var result = await TaskAttachmentService.UploadAttachmentAsync(
                TaskId,
                stream,
                file.Name,
                file.ContentType);

            if (result.IsSuccess)
            {
                await LoadAttachments();
            }
            else
            {
                ErrorMessage = result.Message ?? "Failed to upload attachment";
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message;
        }
        finally
        {
            IsUploading = false;
        }
    }

    private async Task Download(TaskAttachmentDto attachment)
    {
        ErrorMessage = string.Empty;

        var result = await TaskAttachmentService.DownloadAttachmentAsync(TaskId, attachment.Id);

        if (!result.IsSuccess || result.Value is null)
        {
            ErrorMessage = result.Message ?? "Failed to download attachment";
            return;
        }

        var file = result.Value;

        await JS.InvokeVoidAsync(
            "downloadFileFromBytes",
            file.FileName,
            file.ContentType,
            file.Content);
    }

    private async Task Delete(TaskAttachmentDto attachment)
    {
        IsDeleting = true;
        ErrorMessage = string.Empty;

        var result = await TaskAttachmentService.DeleteAttachmentAsync(TaskId, attachment.Id);

        if (result.IsSuccess)
        {
            await LoadAttachments();
        }
        else
        {
            ErrorMessage = result.Message ?? "Failed to delete attachment";
        }

        IsDeleting = false;
    }

    private async Task Close()
    {
        IsVisible = false;
        await OnClose.InvokeAsync();
    }

    private static string FormatSize(long bytes)
    {
        if (bytes < 1024)
        {
            return $"{bytes} B";
        }

        if (bytes < 1024 * 1024)
        {
            return $"{bytes / 1024.0:0.##} KB";
        }

        return $"{bytes / (1024.0 * 1024.0):0.##} MB";
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/ChatModal.razor`

````text
﻿@using Blazor_Web_App.Constants

@if (IsVisible)
{
    <div class="modal fade show d-block" style="background: rgba(0,0,0,0.5);">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">@Localizer[ResourceKeys.ChatTitle]: @TaskTitle</h5>
                    <button class="btn-close" @onclick="Close"></button>
                </div>

                <div class="modal-body d-flex flex-column-reverse" style="max-height: 400px; overflow-y: auto;">
                    @if (IsLoading)
                    {
                        <div class="spinner-border text-primary"></div>
                    }
                    else if (ErrorMessage != string.Empty)
                    {
                        <div class="alert alert-danger">@ErrorMessage</div>
                    }
                    else if (Chat?.Messages is null || Chat.Messages.Count == 0)
                    {
                        <div class="text-muted">@Localizer[ResourceKeys.NoMessages]</div>
                    }
                    else
                    {
                        @foreach (var m in Chat.Messages.AsEnumerable().Reverse())
                        {
                            var own = m.UserId == CurrentUserId;
                            var sender = own ? Localizer[ResourceKeys.You].Value : m.UserName;

                            <div class="mb-3 @(own ? "text-end" : "text-start")">
                                <div>
                                    <small class="text-muted">@sender</small>
                                </div>
                                <div class="d-inline-block text-start p-2 rounded @(own ? "bg-primary text-white" : "bg-light border")"
                                     style="max-width: 75%; word-wrap: break-word; white-space: pre-wrap;">
                                    @m.Text
                                </div>
                                <div>
                                    <small class="text-muted">@m.SentAt.ToLocalTime().ToString(FormatConstants.ShortDatePattern)</small>
                                </div>
                            </div>
                        }
                    }
                </div>

                <div class="modal-footer">
                    <input class="form-control"
                           @bind="NewMessage"
                           @bind:event="oninput"
                           @onkeydown="HandleKeyDown"
                           placeholder="@Localizer[ResourceKeys.MessagePlaceholder]" />
                    <button class="btn btn-primary" @onclick="Send" disabled="@IsSending">
                        @Localizer[ResourceKeys.Send]
                    </button>
                </div>
            </div>
        </div>
    </div>
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/ChatModal.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.Chats;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.Chats;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class ChatModal : ComponentBase, IDisposable
{
    [Inject] public IChatService ChatService { get; set; } = null!;
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int PollingIntervalSeconds = 2;

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public Guid TaskId { get; set; }

    [Parameter] public Guid CurrentUserId { get; set; }

    [Parameter] public EventCallback OnClose { get; set; }

    private ChatDto? Chat;
    private string TaskTitle = string.Empty;
    private string NewMessage = string.Empty;
    private string ErrorMessage = string.Empty;
    private bool IsLoading;
    private bool IsSending;
    private CancellationTokenSource? _cancellationTokenSource;
    private PeriodicTimer? _periodicTimer;
    private Guid? _currentTaskId;
    private bool _disposed;

    protected override async Task OnParametersSetAsync()
    {
        if (!IsVisible || TaskId == Guid.Empty)
        {
            StopPolling();
            _currentTaskId = null;
            return;
        }

        if (_currentTaskId == TaskId && _periodicTimer is not null)
        {
            return;
        }

        StopPolling();
        _currentTaskId = TaskId;

        await LoadTitle();
        await LoadChat();

        StartPolling();
    }

    private void StartPolling()
    {
        if (_periodicTimer is not null)
        {
            return;
        }

        _cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = _cancellationTokenSource.Token;

        var timer = new PeriodicTimer(TimeSpan.FromSeconds(PollingIntervalSeconds));
        _periodicTimer = timer;

        _ = Task.Run(async () =>
        {
            try
            {
                while (await timer.WaitForNextTickAsync(cancellationToken))
                {
                    if (!IsVisible || _disposed)
                    {
                        break;
                    }

                    await SilentReload();
                    await InvokeAsync(StateHasChanged);
                }
            }
            catch (OperationCanceledException) { }
            catch (ObjectDisposedException) { }
        },
        cancellationToken);
    }

    private async Task SilentReload()
    {
        if (Chat is null)
        {
            return;
        }

        var existing = await ChatService.GetChatByTaskIdAsync(TaskId);

        if (existing.IsSuccess && existing.Value is not null)
        {
            Chat = existing.Value;
        }
    }

    private async Task LoadTitle()
    {
        var result = await ProjectTaskService.GetTaskByIdAsync(TaskId);

        if (result.IsSuccess && result.Value is not null)
        {
            TaskTitle = result.Value.Title;
        }
    }

    private async Task LoadChat()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var existing = await ChatService.GetChatByTaskIdAsync(TaskId);

        if (existing.IsSuccess && existing.Value is not null)
        {
            Chat = existing.Value;
        }
        else
        {
            var created = await ChatService.CreateChatAsync(TaskId);

            if (!created.IsSuccess)
            {
                ErrorMessage = created.Message;
                IsLoading = false;
                return;
            }

            Chat = created.Value;
        }

        IsLoading = false;
    }

    private async Task Send()
    {
        if (string.IsNullOrWhiteSpace(NewMessage) || Chat is null)
        {
            return;
        }

        IsSending = true;

        var result = await ChatService.SendMessageAsync(Chat.Id, NewMessage, CurrentUserId);

        if (result.IsSuccess)
        {
            NewMessage = string.Empty;
            await SilentReload();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsSending = false;
    }

    private async Task Close()
    {
        StopPolling();

        IsVisible = false;
        await OnClose.InvokeAsync();
    }

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await Send();
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
        {
            return;
        }

        if (disposing)
        {
            StopPolling();
        }

        _disposed = true;
    }

    private void StopPolling()
    {
        if (_cancellationTokenSource is not null)
        {
            _cancellationTokenSource.Cancel();
            _cancellationTokenSource.Dispose();
            _cancellationTokenSource = null;
        }

        if (_periodicTimer is not null)
        {
            _periodicTimer.Dispose();
            _periodicTimer = null;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/CreateTaskModal.razor`

````text
﻿@if (IsVisible)
{
    <div class="modal fade show d-block" style="background: rgba(0,0,0,0.5);">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">@Localizer[ResourceKeys.CreateTask]</h5>
                    <button class="btn-close" @onclick="CloseModal"></button>
                </div>

                <div class="modal-body">
                    @if (ErrorMessage != string.Empty)
                    {
                        <div class="alert alert-danger">@ErrorMessage</div>
                    }

                    <div class="mb-3">
                        <label class="form-label">@Localizer[ResourceKeys.Title]</label>
                        <input class="form-control" @bind="Title" />
                    </div>

                    <div class="mb-3">
                        <label class="form-label">@Localizer[ResourceKeys.Description]</label>
                        <textarea class="form-control" rows="2" @bind="Description"></textarea>
                    </div>

                    <div class="mb-3">
                        <label class="form-label">@Localizer[ResourceKeys.Price]</label>
                        <input class="form-control" type="number" step="0.01" @bind="Price" />
                    </div>

                    <div class="row">
                        <div class="col-6 mb-3">
                            <label class="form-label">@Localizer[ResourceKeys.Start]</label>
                            <input class="form-control" type="datetime-local" @bind="StartsAt" />
                        </div>
                        <div class="col-6 mb-3">
                            <label class="form-label">@Localizer[ResourceKeys.End]</label>
                            <input class="form-control" type="datetime-local" @bind="EndsAt" />
                        </div>
                    </div>
                </div>

                <div class="modal-footer">
                    <button class="btn btn-secondary" @onclick="CloseModal">@Localizer[ResourceKeys.Cancel]</button>
                    <button class="btn btn-primary" @onclick="SubmitTask" disabled="@IsSubmitting">
                        @(IsSubmitting ? "..." : Localizer[ResourceKeys.Create].Value)
                    </button>
                </div>
            </div>
        </div>
    </div>
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/CreateTaskModal.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Requests.ProjectTasks;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class CreateTaskModal : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int DefaultDurationDays = 7;

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public EventCallback OnCreated { get; set; }

    [Parameter] public EventCallback OnClose { get; set; }

    private string Title = string.Empty;
    private string Description = string.Empty;
    private decimal Price;
    private DateTimeOffset StartsAt = DateTimeOffset.Now;
    private DateTimeOffset EndsAt = DateTimeOffset.Now.AddDays(DefaultDurationDays);
    private bool IsSubmitting;
    private string ErrorMessage = string.Empty;

    private async Task SubmitTask()
    {
        IsSubmitting = true;
        ErrorMessage = string.Empty;

        var dto = new CreateProjectTaskDto
        {
            Title = Title,
            Description = Description,
            Price = Price,
            StartsAt = StartsAt,
            EndsAt = EndsAt
        };

        var result = await ProjectTaskService.CreateTaskAsync(dto);

        if (result.IsSuccess)
        {
            await OnCreated.InvokeAsync();
            await CloseModal();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsSubmitting = false;
    }

    private async Task CloseModal()
    {
        IsVisible = false;
        await OnClose.InvokeAsync();
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/EditTaskModal.razor`

````text
﻿@if (IsVisible)
{
    <div class="modal fade show d-block" style="background: rgba(0,0,0,0.5);">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">@Localizer[ResourceKeys.EditTask]</h5>
                    <button class="btn-close" @onclick="CloseModal"></button>
                </div>

                <div class="modal-body">
                    @if (ErrorMessage != string.Empty)
                    {
                        <div class="alert alert-danger">@ErrorMessage</div>
                    }

                    <div class="mb-3">
                        <label class="form-label">@Localizer[ResourceKeys.Title]</label>
                        <input class="form-control" @bind="Title" />
                    </div>

                    <div class="mb-3">
                        <label class="form-label">@Localizer[ResourceKeys.Description]</label>
                        <textarea class="form-control" rows="2" @bind="Description"></textarea>
                    </div>

                    <div class="mb-3">
                        <label class="form-label">@Localizer[ResourceKeys.Price]</label>
                        <input class="form-control" type="number" step="0.01" @bind="Price" />
                    </div>

                    <div class="row">
                        <div class="col-6 mb-3">
                            <label class="form-label">@Localizer[ResourceKeys.Start]</label>
                            <input class="form-control" type="datetime-local" @bind="StartsAt" />
                        </div>
                        <div class="col-6 mb-3">
                            <label class="form-label">@Localizer[ResourceKeys.End]</label>
                            <input class="form-control" type="datetime-local" @bind="EndsAt" />
                        </div>
                    </div>
                </div>

                <div class="modal-footer">
                    <button class="btn btn-secondary" @onclick="CloseModal">@Localizer[ResourceKeys.Cancel]</button>
                    <button class="btn btn-primary" @onclick="Submit" disabled="@IsSubmitting">
                        @(IsSubmitting ? "..." : Localizer[ResourceKeys.Save].Value)
                    </button>
                </div>
            </div>
        </div>
    </div>
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/EditTaskModal.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Requests.ProjectTasks;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class EditTaskModal : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public ProjectTaskDto? Task { get; set; }

    [Parameter] public EventCallback OnUpdated { get; set; }

    [Parameter] public EventCallback OnClose { get; set; }

    private string Title = string.Empty;
    private string Description = string.Empty;
    private decimal Price;
    private DateTimeOffset StartsAt;
    private DateTimeOffset EndsAt;
    private bool IsSubmitting;
    private string ErrorMessage = string.Empty;

    protected override void OnParametersSet()
    {
        if (Task is null)
        {
            return;
        }

        Title = Task.Title;
        Description = Task.Description;
        Price = Task.Price;
        StartsAt = Task.StartsAt;
        EndsAt = Task.EndsAt;
    }

    private async Task Submit()
    {
        if (Task is null)
        {
            return;
        }

        IsSubmitting = true;
        ErrorMessage = string.Empty;

        var dto = new UpdateProjectTaskDto(
            Title,
            Description,
            Price,
            StartsAt,
            EndsAt);

        var result = await ProjectTaskService.UpdateTaskAsync(Task.Id, dto);

        if (result.IsSuccess)
        {
            await OnUpdated.InvokeAsync();
            await CloseModal();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsSubmitting = false;
    }

    private async Task CloseModal()
    {
        IsVisible = false;
        await OnClose.InvokeAsync();
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/RateExecutorModal.razor`

````text
﻿@if (IsVisible)
{
    <div class="modal fade show d-block" style="background: rgba(0,0,0,0.5);">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">@Localizer[ResourceKeys.Rate]</h5>
                    <button class="btn-close" @onclick="CloseModal"></button>
                </div>

                <div class="modal-body">
                    @if (ErrorMessage != string.Empty)
                    {
                        <div class="alert alert-danger">@ErrorMessage</div>
                    }

                    <p>@string.Format(Localizer[ResourceKeys.SelectRating], MinRating, MaxRating)</p>

                    <div class="d-flex gap-2 mb-3">
                        @for (var i = MinRating; i <= MaxRating; i++)
                        {
                            var value = i;

                            <button class="btn @(SelectedRating == value ? "btn-primary" : "btn-outline-primary")"
                                    @onclick="() => SelectedRating = value">
                                @value
                            </button>
                        }
                    </div>
                </div>

                <div class="modal-footer">
                    <button class="btn btn-secondary" @onclick="Skip" disabled="@IsSubmitting">
                        @Localizer[ResourceKeys.Skip]
                    </button>
                    <button class="btn btn-primary" @onclick="Submit" disabled="@IsSubmitting">
                        @(IsSubmitting ? "..." : Localizer[ResourceKeys.Submit].Value)
                    </button>
                </div>
            </div>
        </div>
    </div>
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/RateExecutorModal.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class RateExecutorModal : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int MinRating = 1;
    private const int MaxRating = 5;

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public Guid TaskId { get; set; }

    [Parameter] public EventCallback OnCompleted { get; set; }

    [Parameter] public EventCallback OnClose { get; set; }

    private int SelectedRating = MinRating;
    private bool IsSubmitting;
    private string ErrorMessage = string.Empty;

    protected override void OnParametersSet()
    {
        if (IsVisible)
        {
            SelectedRating = MinRating;
            ErrorMessage = string.Empty;
        }
    }

    private async Task Submit()
    {
        await Send(SelectedRating);
    }

    private async Task Skip()
    {
        await Send(null);
    }

    private async Task Send(int? rating)
    {
        IsSubmitting = true;
        ErrorMessage = string.Empty;

        var result = await ProjectTaskService.MarkAsDoneAsync(TaskId, rating);

        if (result.IsSuccess)
        {
            await OnCompleted.InvokeAsync();
            await CloseModal();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsSubmitting = false;
    }

    private async Task CloseModal()
    {
        IsVisible = false;
        await OnClose.InvokeAsync();
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/ResponsesModal.razor`

````text
﻿@using Blazor_Web_App.Constants

@if (IsVisible)
{
    <div class="modal fade show d-block" style="background: rgba(0,0,0,0.5);">
        <div class="modal-dialog modal-dialog-centered">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">@Localizer[ResourceKeys.CandidatesFor] "@TaskTitle"</h5>
                    <button class="btn-close" @onclick="Close"></button>
                </div>

                <div class="modal-body">
                    @if (IsLoading)
                    {
                        <div class="spinner-border text-primary"></div>
                    }
                    else if (ErrorMessage != string.Empty)
                    {
                        <div class="alert alert-danger">@ErrorMessage</div>
                    }
                    else if (Responses is null || Responses.Count == 0)
                    {
                        <div class="alert alert-info">@Localizer[ResourceKeys.NoCandidates]</div>
                    }
                    else
                    {
                        <ul class="list-group">
                            @foreach (var resp in Responses)
                            {
                                <li class="list-group-item d-flex justify-content-between align-items-center">
                                    <div>
                                        <strong>@resp.ExecutorName</strong>
                                        <span class="badge bg-warning text-dark ms-2">
                                            @(resp.ExecutorRating.HasValue
                                                ? resp.ExecutorRating.Value.ToString(FormatConstants.RatingFormat)
                                                : FormatConstants.EmptyPlaceholder)
                                        </span>
                                        <br />
                                        <small class="text-muted">
                                            @Localizer[ResourceKeys.RespondedAt] @resp.RespondedAt.Date.ToShortDateString()
                                        </small>
                                    </div>

                                    <button class="btn btn-sm btn-primary"
                                            @onclick="() => HandleAssign(resp.ExecutorId)"
                                            disabled="@IsAssigning">
                                        @(IsAssigning && _assigningId == resp.ExecutorId ? "..." : Localizer[ResourceKeys.Assign].Value)
                                    </button>
                                </li>
                            }
                        </ul>
                    }
                </div>
            </div>
        </div>
    </div>
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/ResponsesModal.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class ResponsesModal : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public Guid TaskId { get; set; }

    [Parameter] public EventCallback OnAssigned { get; set; }

    [Parameter] public EventCallback OnClose { get; set; }

    private List<TaskResponseDto>? Responses;
    private Guid _assigningId;
    private bool IsLoading;
    private bool IsAssigning;
    private string ErrorMessage = string.Empty;
    private string TaskTitle = string.Empty;

    protected override async Task OnParametersSetAsync()
    {
        if (!IsVisible || TaskId == Guid.Empty)
        {
            return;
        }

        await LoadTitle();
        await LoadResponses();
    }

    private async Task LoadTitle()
    {
        var result = await ProjectTaskService.GetTaskByIdAsync(TaskId);

        if (result.IsSuccess && result.Value is not null)
        {
            TaskTitle = result.Value.Title;
        }
    }

    private async Task LoadResponses()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await ProjectTaskService.GetTaskResponsesAsync(TaskId);

        if (result.IsSuccess)
        {
            Responses = result.Value;
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsLoading = false;
    }

    private async Task HandleAssign(Guid executorId)
    {
        IsAssigning = true;
        _assigningId = executorId;

        var result = await ProjectTaskService.AssignExecutorAsync(TaskId, executorId);

        if (result.IsSuccess)
        {
            await OnAssigned.InvokeAsync();
            Close();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsAssigning = false;
        _assigningId = Guid.Empty;
    }

    private void Close()
    {
        IsVisible = false;
        OnClose.InvokeAsync();
    }
}
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/TaskCard.razor`

````text
﻿@using Blazor_Web_App.Constants

<div class="card h-100 d-flex flex-column">
    <div class="card-body position-relative">
        @if (ShowDeleteButton)
        {
            <button class="btn btn-sm btn-outline-danger position-absolute top-0 end-0 m-2"
                    title="@Localizer[ResourceKeys.Delete]"
                    @onclick="HandleDelete">
                ✕
            </button>
        }

        <h5 class="card-title pe-5">@ProjectTask.Title</h5>
        <p class="text-muted small mb-2">@ProjectTask.Description</p>

        <div class="d-flex justify-content-between align-items-center">
            <span class="badge bg-secondary">@ProjectTask.Status</span>
            <span class="fw-bold">@ProjectTask.Currency@ProjectTask.Price.ToString(PriceFormat)</span>

            @if (ProjectTask.ProjectRating.HasValue)
            {
                <span class="badge bg-warning text-dark">
                    @ProjectTask.ProjectRating.Value.ToString(FormatConstants.RatingFormat)
                </span>
            }
        </div>

        <small class="text-muted d-block mt-2">
            @ProjectTask.StartsAt.Date.ToShortDateString() - @ProjectTask.EndsAt.Date.ToShortDateString()
        </small>
    </div>

    <div class="card-footer bg-transparent border-top-0 p-2 mt-auto d-flex flex-wrap gap-1">
        @if (ShowRespondButton)
        {
            <button class="btn btn-sm flex-fill @(IsResponded ? "btn-secondary" : "btn-success")"
                    @onclick="HandleRespond"
                    disabled="@IsResponded">
                @(IsResponded ? Localizer[ResourceKeys.Responded] : Localizer[ResourceKeys.Respond])
            </button>
        }

        @if (ShowChatButton)
        {
            <button class="btn btn-sm btn-outline-info flex-fill" @onclick="HandleOpenChat">
                @Localizer[ResourceKeys.Chat]
            </button>
        }

        @if (ShowMarkDoneButton)
        {
            <button class="btn btn-sm btn-outline-success flex-fill" @onclick="HandleMarkDone">
                @Localizer[ResourceKeys.Done]
            </button>
        }

        @if (ShowEditButton)
        {
            <button class="btn btn-sm btn-outline-info flex-fill" @onclick="HandleEdit">
                @Localizer[ResourceKeys.Edit]
            </button>
        }

        @if (ShowCancelButton)
        {
            <button class="btn btn-sm btn-outline-info flex-fill" @onclick="HandleCancel">
                @Localizer[ResourceKeys.Cancel]
            </button>
        }

        @if (ShowAttachmentsButton)
        {
            <button class="btn btn-sm btn-outline-secondary flex-fill" @onclick="HandleOpenAttachments">
                @Localizer[ResourceKeys.Attachments]
            </button>
        }
    </div>
</div>
````

---

## FILE: `Blazor Web App/Components/Pages/TasksModals/TaskCard.razor.cs`

````csharp
﻿using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class TaskCard : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    public const string PriceFormat = "0.00";

    [Parameter, EditorRequired] public ProjectTaskDto ProjectTask { get; set; } = null!;

    [Parameter] public bool IsExecutor { get; set; }

    [Parameter] public bool IsCustomer { get; set; }

    [Parameter] public bool IsResponded { get; set; }

    [Parameter] public EventCallback<Guid> OnDeleted { get; set; }

    [Parameter] public EventCallback<Guid> OnRespond { get; set; }

    [Parameter] public EventCallback<Guid> OnOpenChat { get; set; }

    [Parameter] public EventCallback<Guid> OnMarkDone { get; set; }

    [Parameter] public EventCallback<Guid> OnCancel { get; set; }

    [Parameter] public EventCallback<Guid> OnEdit { get; set; }

    [Parameter] public Guid CurrentUserId { get; set; }

    [Parameter] public EventCallback<Guid> OnOpenAttachments { get; set; }

    private bool ShowEditButton
        => IsCustomer
        && ProjectTask.Status != ProjectTaskStatus.InProgress
        && ProjectTask.Status != ProjectTaskStatus.Done
        && ProjectTask.Status != ProjectTaskStatus.Cancelled;

    private bool ShowDeleteButton
        => IsCustomer
        && ProjectTask.Status != ProjectTaskStatus.Done
        && ProjectTask.Status != ProjectTaskStatus.Cancelled;

    private bool ShowRespondButton
        => IsExecutor && ProjectTask.Status == ProjectTaskStatus.Published;

    private bool ShowChatButton
        => ProjectTask.Status == ProjectTaskStatus.InProgress;

    private bool ShowMarkDoneButton
        => IsCustomer && ProjectTask.Status == ProjectTaskStatus.InProgress;

    private bool ShowCancelButton
        => IsCustomer
        && ProjectTask.Status != ProjectTaskStatus.Done
        && ProjectTask.Status != ProjectTaskStatus.Cancelled;

    private bool ShowAttachmentsButton
        => ProjectTask.CustomerId == CurrentUserId
        || ProjectTask.ExecutorId == CurrentUserId;

    private async Task HandleOpenAttachments()
    {
        await OnOpenAttachments.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleRespond()
    {
        await OnRespond.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleDelete()
    {
        var result = await ProjectTaskService.DeleteTaskAsync(ProjectTask.Id);

        if (result.IsSuccess)
        {
            await OnDeleted.InvokeAsync(ProjectTask.Id);
        }
    }

    private async Task HandleOpenChat()
    {
        await OnOpenChat.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleMarkDone()
    {
        await OnMarkDone.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleCancel()
    {
        await OnCancel.InvokeAsync(ProjectTask.Id);
    }

    private async Task HandleEdit()
    {
        await OnEdit.InvokeAsync(ProjectTask.Id);
    }
}
````

---

## FILE: `Blazor Web App/Components/Routes.razor`

````text
﻿@rendermode @(new InteractiveServerRenderMode(prerender: false))

<CascadingAuthenticationState>
    <Router AppAssembly="typeof(Program).Assembly" NotFoundPage="typeof(Pages.Errors.NotFound)">
        <Found Context="routeData">
            <AuthorizeRouteView RouteData="routeData" DefaultLayout="typeof(Layout.MainLayout)">
                <NotAuthorized>
                    <RedirectToLogin />
                </NotAuthorized>
            </AuthorizeRouteView>
            <FocusOnNavigate RouteData="routeData" Selector="h1" />
        </Found>
    </Router>
</CascadingAuthenticationState>
````

---

## FILE: `Blazor Web App/Components/_Imports.razor`

````text
﻿@using System.Net.Http
@using System.Net.Http.Json
@using Microsoft.AspNetCore.Components.Routing
@using Microsoft.AspNetCore.Components.Web
@using static Microsoft.AspNetCore.Components.Web.RenderMode
@using Microsoft.AspNetCore.Components.Web.Virtualization
@using Microsoft.JSInterop
@using Blazor_Web_App
@using Blazor_Web_App.Components
@using Blazor_Web_App.Components.Layout
@using Microsoft.AspNetCore.Authorization
@using Microsoft.AspNetCore.Components.Authorization
@using Blazor_Web_App.Services
@using Shared.Dtos.Responses.UserActions
@using Shared.Dtos.Responses.Users
@using Blazor_Web_App.Components.Pages.Admin;
@using Blazor_Web_App.Components.Pages.Auth;
@using Blazor_Web_App.Components.Pages.Errors;
@using Blazor_Web_App.Components.Pages.Executor;
@using Blazor_Web_App.Components.Pages.TasksModals;
@using Microsoft.Extensions.Localization
@using Blazor_Web_App.Resources
@using Blazor_Web_App.Constants

@attribute [Authorize]
````

---

## FILE: `Blazor Web App/Constants/AttachmentConstants.cs`

````csharp
﻿namespace Blazor_Web_App.Constants;

public static class AttachmentConstants
{
    public const int Zero = 0;
}
````

---

## FILE: `Blazor Web App/Constants/CultureConstants.cs`

````csharp
﻿namespace Blazor_Web_App.Constants;

public static class CultureConstants
{
    public const string English = "en-US";
    public const string Russian = "ru-RU";

    public const string Default = English;

    public const string StorageKey = "app.culture";

    public static readonly string[] Supported =
    [
        English,
        Russian
    ];
}
````

---

## FILE: `Blazor Web App/Constants/FormatConstants.cs`

````csharp
﻿namespace Blazor_Web_App.Constants;

public static class FormatConstants
{
    public const string ShortDatePattern = "g";
    public const string RatingFormat = "0.0";
    public const string EmptyPlaceholder = "—";
}
````

---

## FILE: `Blazor Web App/Constants/Pagination.cs`

````csharp
﻿namespace Blazor_Web_App.Constants;

public static class Pagination
{
    public const int FirstPage = 1;
    public const int DefaultPageSize = 10;
}
````

---

## FILE: `Blazor Web App/Constants/ServiceMessages.cs`

````csharp
﻿namespace Blazor_Web_App.Constants;

public static class ServiceMessages
{
    public const string EmptyResponse = "Empty response from server";
    public const string DeserializationFailed = "Failed to deserialize response";
    public const string UnknownServerError = "Unknown server error";
    public const string UserIdNotFound = "User ID not found";
}
````

---

## FILE: `Blazor Web App/Extensions/ServiceCollectionExtensions.cs`

````csharp
﻿using Blazor_Web_App.Services;
using Blazor_Web_App.Services.Culture;
using Blazor_Web_App.Services.LocalStorage;
using Blazor_Web_App.Services.Receivers.Auth;
using Blazor_Web_App.Services.Receivers.Chats;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Blazor_Web_App.Services.Receivers.TaskAttachments;
using Blazor_Web_App.Services.Receivers.UserActions;
using Blazor_Web_App.Services.Receivers.Users;
using Blazor_Web_App.Settings;
using Microsoft.AspNetCore.Components.Authorization;

namespace Blazor_Web_App.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection ConfigureHttpClients(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var apiSettings = configuration
            .GetSection(ApiSettings.SectionName)
            .Get<ApiSettings>();

        services.AddHttpClient<IAuthService, AuthService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/auth/"));

        services.AddHttpClient<IProjectTaskService, ProjectTaskService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/projecttask/"));

        services.AddHttpClient<IChatService, ChatService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/chat/"));

        services.AddHttpClient<ITaskAttachmentService, TaskAttachmentService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/tasks/"));

        services.AddHttpClient<IUserActionService, UserActionService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/useraction/"));

        services.AddHttpClient<IUserService, UserService>(client =>
            client.BaseAddress = new Uri($"{apiSettings!.ApiUrl}/api/user/"));

        return services;
    }

    public static IServiceCollection ConfigureAppSettings(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddOptions<ApiSettings>()
            .Bind(configuration.GetSection(ApiSettings.SectionName))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        return services;
    }

    public static IServiceCollection AddServices(
        this IServiceCollection services)
    {
        services.AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

        services.AddLocalization()
                .AddScoped<ICultureService, CultureService>();

        return services;
    }

    public static IServiceCollection AddAuth(
        this IServiceCollection services)
    {
        const string defaultString = "Identity.Application";

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = defaultString;
            options.DefaultChallengeScheme = defaultString;
        })
        .AddCookie(defaultString, options =>
        {
            options.Events.OnRedirectToLogin = context =>
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;

                return Task.CompletedTask;
            };
        });

        services.AddAuthorizationCore()
                .AddCascadingAuthenticationState();

        return services;
    }
}
````

---

## FILE: `Blazor Web App/Modals/ModalState.cs`

````csharp
﻿namespace Blazor_Web_App.Modals;

public class ModalState
{
    public bool IsOpen { get; private set; }
    public Guid TaskId { get; private set; }
    public string TaskTitle { get; private set; } = string.Empty;

    public void Open(Guid taskId, string title = "")
    {
        TaskId = taskId;
        TaskTitle = title;
        IsOpen = true;
    }

    public void Close()
    {
        IsOpen = false;
    }
}
````

---

## FILE: `Blazor Web App/Program.cs`

````csharp
using Blazor_Web_App.Components;
using Blazor_Web_App.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.ConfigureAppSettings(builder.Configuration)
                .AddAuth()
                .ConfigureHttpClients(builder.Configuration)
                .AddServices();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
````

---

## FILE: `Blazor Web App/Properties/launchSettings.json`

````json
{
  "$schema": "https://json.schemastore.org/launchsettings.json",
    "profiles": {
      "http": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "http://localhost:5020",
        "environmentVariables": {
          "ASPNETCORE_ENVIRONMENT": "Development"
        }
      },
      "https": {
        "commandName": "Project",
        "dotnetRunMessages": true,
        "launchBrowser": true,
        "applicationUrl": "https://localhost:7263;http://localhost:5020",
        "environmentVariables": {
          "ASPNETCORE_ENVIRONMENT": "Development"
        }
      }
    }
  }
````

---

## FILE: `Blazor Web App/Resources/ResourceKeys.cs`

````csharp
﻿namespace Blazor_Web_App.Resources;

public static class ResourceKeys
{
    public const string AppName = nameof(AppName);
    public const string SignIn = nameof(SignIn);
    public const string SignOut = nameof(SignOut);
    public const string Register = nameof(Register);
    public const string AdminUsers = nameof(AdminUsers);
    public const string AdminActions = nameof(AdminActions);
    public const string MyTasks = nameof(MyTasks);
    public const string BrowseTasks = nameof(BrowseTasks);
    public const string MyAssigned = nameof(MyAssigned);

    public const string Hello = nameof(Hello);
    public const string QuickActions = nameof(QuickActions);
    public const string ManageMyTasks = nameof(ManageMyTasks);
    public const string OpenTasks = nameof(OpenTasks);
    public const string FindTasks = nameof(FindTasks);
    public const string Browse = nameof(Browse);
    public const string TasksAssigned = nameof(TasksAssigned);
    public const string OpenAssigned = nameof(OpenAssigned);
    public const string ManageUsers = nameof(ManageUsers);
    public const string OpenUsers = nameof(OpenUsers);
    public const string ViewLog = nameof(ViewLog);
    public const string OpenLog = nameof(OpenLog);

    public const string NewTask = nameof(NewTask);
    public const string SearchPlaceholder = nameof(SearchPlaceholder);
    public const string Search = nameof(Search);
    public const string Clear = nameof(Clear);
    public const string NoTasksFound = nameof(NoTasksFound);
    public const string ViewCandidates = nameof(ViewCandidates);
    public const string Prev = nameof(Prev);
    public const string Next = nameof(Next);
    public const string AvailableTasks = nameof(AvailableTasks);
    public const string MyAssignedTasks = nameof(MyAssignedTasks);
    public const string NoAssignedTasks = nameof(NoAssignedTasks);

    public const string Respond = nameof(Respond);
    public const string Responded = nameof(Responded);
    public const string Chat = nameof(Chat);
    public const string Done = nameof(Done);
    public const string Edit = nameof(Edit);
    public const string Cancel = nameof(Cancel);
    public const string Attachments = nameof(Attachments);

    public const string UploadFile = nameof(UploadFile);
    public const string MaxSizeLabel = nameof(MaxSizeLabel);
    public const string NoAttachments = nameof(NoAttachments);
    public const string Download = nameof(Download);
    public const string Delete = nameof(Delete);
    public const string Close = nameof(Close);

    // Chat
    public const string ChatTitle = nameof(ChatTitle);
    public const string NoMessages = nameof(NoMessages);
    public const string MessagePlaceholder = nameof(MessagePlaceholder);
    public const string Send = nameof(Send);
    public const string You = nameof(You);

    public const string CreateTask = nameof(CreateTask);
    public const string EditTask = nameof(EditTask);
    public const string Title = nameof(Title);
    public const string Description = nameof(Description);
    public const string Price = nameof(Price);
    public const string Start = nameof(Start);
    public const string End = nameof(End);
    public const string Create = nameof(Create);
    public const string Save = nameof(Save);

    // Responses
    public const string CandidatesFor = nameof(CandidatesFor);
    public const string NoCandidates = nameof(NoCandidates);
    public const string RespondedAt = nameof(RespondedAt);
    public const string Assign = nameof(Assign);

    public const string Rate = nameof(Rate);
    public const string SelectRating = nameof(SelectRating);
    public const string Skip = nameof(Skip);
    public const string Submit = nameof(Submit);

    public const string Login = nameof(Login);
    public const string Password = nameof(Password);
    public const string Loading = nameof(Loading);
    public const string NoAccount = nameof(NoAccount);
    public const string LoggedInSuccess = nameof(LoggedInSuccess);
    public const string RegisteredSuccess = nameof(RegisteredSuccess);
    public const string Customer = nameof(Customer);
    public const string Executor = nameof(Executor);

    public const string Users = nameof(Users);
    public const string Name = nameof(Name);
    public const string Role = nameof(Role);
    public const string Rating = nameof(Rating);
    public const string Blocked = nameof(Blocked);
    public const string Actions = nameof(Actions);
    public const string Yes = nameof(Yes);
    public const string No = nameof(No);
    public const string Block = nameof(Block);
    public const string Unblock = nameof(Unblock);
    public const string NoUsersFound = nameof(NoUsersFound);
    public const string AccessDenied = nameof(AccessDenied);
    public const string UserActions = nameof(UserActions);
    public const string ActionType = nameof(ActionType);
    public const string All = nameof(All);
    public const string Apply = nameof(Apply);
    public const string User = nameof(User);
    public const string Action = nameof(Action);
    public const string Entity = nameof(Entity);
    public const string When = nameof(When);
    public const string NoActionsFound = nameof(NoActionsFound);
}
````

---

## FILE: `Blazor Web App/Resources/SharedResources.cs`

````csharp
﻿namespace Blazor_Web_App.Resources;

public class SharedResources
{
}
````

---

## FILE: `Blazor Web App/Resources/SharedResources.resx`

````text
﻿<?xml version="1.0" encoding="utf-8"?>
<root>
	<!-- 
		Microsoft ResX Schema

		Version 1.3

		The primary goals of this format is to allow a simple XML format 
		that is mostly human readable. The generation and parsing of the 
		various data types are done through the TypeConverter classes 
		associated with the data types.

		Example:

		... ado.net/XML headers & schema ...
		<resheader name="resmimetype">text/microsoft-resx</resheader>
		<resheader name="version">1.3</resheader>
		<resheader name="reader">System.Resources.ResXResourceReader, System.Windows.Forms, ...</resheader>
		<resheader name="writer">System.Resources.ResXResourceWriter, System.Windows.Forms, ...</resheader>
		<data name="Name1">this is my long string</data>
		<data name="Color1" type="System.Drawing.Color, System.Drawing">Blue</data>
		<data name="Bitmap1" mimetype="application/x-microsoft.net.object.binary.base64">
			[base64 mime encoded serialized .NET Framework object]
		</data>
		<data name="Icon1" type="System.Drawing.Icon, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
			[base64 mime encoded string representing a byte array form of the .NET Framework object]
		</data>

		There are any number of "resheader" rows that contain simple 
		name/value pairs.

		Each data row contains a name, and value. The row also contains a 
		type or mimetype. Type corresponds to a .NET class that support 
		text/value conversion through the TypeConverter architecture. 
		Classes that don't support this are serialized and stored with the 
		mimetype set.

		The mimetype is used for serialized objects, and tells the 
		ResXResourceReader how to depersist the object. This is currently not 
		extensible. For a given mimetype the value must be set accordingly:

		Note - application/x-microsoft.net.object.binary.base64 is the format 
		that the ResXResourceWriter will generate, however the reader can 
		read any of the formats listed below.

		mimetype: application/x-microsoft.net.object.binary.base64
		value   : The object must be serialized with 
			: System.Serialization.Formatters.Binary.BinaryFormatter
			: and then encoded with base64 encoding.

		mimetype: application/x-microsoft.net.object.soap.base64
		value   : The object must be serialized with 
			: System.Runtime.Serialization.Formatters.Soap.SoapFormatter
			: and then encoded with base64 encoding.

		mimetype: application/x-microsoft.net.object.bytearray.base64
		value   : The object must be serialized into a byte array 
			: using a System.ComponentModel.TypeConverter
			: and then encoded with base64 encoding.
	-->
	
	<xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
		<xsd:element name="root" msdata:IsDataSet="true">
			<xsd:complexType>
				<xsd:choice maxOccurs="unbounded">
					<xsd:element name="data">
						<xsd:complexType>
							<xsd:sequence>
								<xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
								<xsd:element name="comment" type="xsd:string" minOccurs="0" msdata:Ordinal="2" />
							</xsd:sequence>
							<xsd:attribute name="name" type="xsd:string" msdata:Ordinal="1" />
							<xsd:attribute name="type" type="xsd:string" msdata:Ordinal="3" />
							<xsd:attribute name="mimetype" type="xsd:string" msdata:Ordinal="4" />
						</xsd:complexType>
					</xsd:element>
					<xsd:element name="resheader">
						<xsd:complexType>
							<xsd:sequence>
								<xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
							</xsd:sequence>
							<xsd:attribute name="name" type="xsd:string" use="required" />
						</xsd:complexType>
					</xsd:element>
				</xsd:choice>
			</xsd:complexType>
		</xsd:element>
	</xsd:schema>
	<resheader name="resmimetype">
		<value>text/microsoft-resx</value>
	</resheader>
	<resheader name="version">
		<value>1.3</value>
	</resheader>
	<resheader name="reader">
		<value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=2.0.3500.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
	</resheader>
	<resheader name="writer">
		<value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=2.0.3500.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
	</resheader>
	<data name="AppName" xml:space="preserve"><value>Task Marketplace</value></data>
	<data name="SignIn" xml:space="preserve"><value>Sign In</value></data>
	<data name="SignOut" xml:space="preserve"><value>Sign Out</value></data>
	<data name="Register" xml:space="preserve"><value>Register</value></data>
	<data name="AdminUsers" xml:space="preserve"><value>Admin: Users</value></data>
	<data name="AdminActions" xml:space="preserve"><value>Admin: Actions</value></data>
	<data name="MyTasks" xml:space="preserve"><value>My Tasks</value></data>
	<data name="BrowseTasks" xml:space="preserve"><value>Browse Tasks</value></data>
	<data name="MyAssigned" xml:space="preserve"><value>My Assigned</value></data>

	<data name="Hello" xml:space="preserve"><value>Hello</value></data>
	<data name="QuickActions" xml:space="preserve"><value>Quick actions</value></data>
	<data name="ManageMyTasks" xml:space="preserve"><value>Manage your published tasks, view candidates and pick an executor.</value></data>
	<data name="OpenTasks" xml:space="preserve"><value>Open tasks</value></data>
	<data name="FindTasks" xml:space="preserve"><value>Find new published tasks and respond to them.</value></data>
	<data name="Browse" xml:space="preserve"><value>Browse</value></data>
	<data name="TasksAssigned" xml:space="preserve"><value>Tasks assigned to you, chats with customers and deadlines.</value></data>
	<data name="OpenAssigned" xml:space="preserve"><value>Open assigned</value></data>
	<data name="ManageUsers" xml:space="preserve"><value>Manage users, roles, blocks and removals.</value></data>
	<data name="OpenUsers" xml:space="preserve"><value>Open users</value></data>
	<data name="ViewLog" xml:space="preserve"><value>View the user activity log with filters.</value></data>
	<data name="OpenLog" xml:space="preserve"><value>Open log</value></data>

	<data name="NewTask" xml:space="preserve"><value>+ New Task</value></data>
	<data name="SearchPlaceholder" xml:space="preserve"><value>Search by title...</value></data>
	<data name="Search" xml:space="preserve"><value>Search</value></data>
	<data name="Clear" xml:space="preserve"><value>Clear</value></data>
	<data name="NoTasksFound" xml:space="preserve"><value>No tasks found.</value></data>
	<data name="ViewCandidates" xml:space="preserve"><value>View Candidates</value></data>
	<data name="Prev" xml:space="preserve"><value>Prev</value></data>
	<data name="Next" xml:space="preserve"><value>Next</value></data>
	<data name="AvailableTasks" xml:space="preserve"><value>Available Tasks</value></data>
	<data name="MyAssignedTasks" xml:space="preserve"><value>My Assigned Tasks</value></data>
	<data name="NoAssignedTasks" xml:space="preserve"><value>No assigned tasks.</value></data>

	<data name="Respond" xml:space="preserve"><value>Respond</value></data>
	<data name="Responded" xml:space="preserve"><value>Responded</value></data>
	<data name="Chat" xml:space="preserve"><value>Chat</value></data>
	<data name="Done" xml:space="preserve"><value>Done</value></data>
	<data name="Edit" xml:space="preserve"><value>Edit</value></data>
	<data name="Cancel" xml:space="preserve"><value>Cancel</value></data>
	<data name="Attachments" xml:space="preserve"><value>Attachments</value></data>

	<data name="UploadFile" xml:space="preserve"><value>Upload file</value></data>
	<data name="MaxSizeLabel" xml:space="preserve"><value>(max {0} MB)</value></data>
	<data name="NoAttachments" xml:space="preserve"><value>No attachments yet.</value></data>
	<data name="Download" xml:space="preserve"><value>Download</value></data>
	<data name="Delete" xml:space="preserve"><value>Delete</value></data>
	<data name="Close" xml:space="preserve"><value>Close</value></data>

	<data name="ChatTitle" xml:space="preserve"><value>Chat</value></data>
	<data name="NoMessages" xml:space="preserve"><value>No messages yet</value></data>
	<data name="MessagePlaceholder" xml:space="preserve"><value>Message...</value></data>
	<data name="Send" xml:space="preserve"><value>Send</value></data>
	<data name="You" xml:space="preserve"><value>You</value></data>

	<data name="CreateTask" xml:space="preserve"><value>New Task</value></data>
	<data name="EditTask" xml:space="preserve"><value>Edit Task</value></data>
	<data name="Title" xml:space="preserve"><value>Title</value></data>
	<data name="Description" xml:space="preserve"><value>Description</value></data>
	<data name="Price" xml:space="preserve"><value>Price</value></data>
	<data name="Start" xml:space="preserve"><value>Start</value></data>
	<data name="End" xml:space="preserve"><value>End</value></data>
	<data name="Create" xml:space="preserve"><value>Create</value></data>
	<data name="Save" xml:space="preserve"><value>Save</value></data>

	<data name="CandidatesFor" xml:space="preserve"><value>Candidates for</value></data>
	<data name="NoCandidates" xml:space="preserve"><value>No candidates yet.</value></data>
	<data name="RespondedAt" xml:space="preserve"><value>Responded:</value></data>
	<data name="Assign" xml:space="preserve"><value>Assign</value></data>

	<data name="Rate" xml:space="preserve"><value>Rate</value></data>
	<data name="SelectRating" xml:space="preserve"><value>Select rating ({0}–{1}):</value></data>
	<data name="Skip" xml:space="preserve"><value>Skip</value></data>
	<data name="Submit" xml:space="preserve"><value>Submit</value></data>

	<data name="Login" xml:space="preserve"><value>Login</value></data>
	<data name="Password" xml:space="preserve"><value>Password</value></data>
	<data name="Loading" xml:space="preserve"><value>Loading...</value></data>
	<data name="NoAccount" xml:space="preserve"><value>Don't have an account? Register</value></data>
	<data name="LoggedInSuccess" xml:space="preserve"><value>Logged in successfully!</value></data>
	<data name="RegisteredSuccess" xml:space="preserve"><value>Registered successfully!</value></data>
	<data name="Customer" xml:space="preserve"><value>Customer</value></data>
	<data name="Executor" xml:space="preserve"><value>Executor</value></data>

	<data name="Users" xml:space="preserve"><value>Users</value></data>
	<data name="Name" xml:space="preserve"><value>Name</value></data>
	<data name="Role" xml:space="preserve"><value>Role</value></data>
	<data name="Rating" xml:space="preserve"><value>Rating</value></data>
	<data name="Blocked" xml:space="preserve"><value>Blocked</value></data>
	<data name="Actions" xml:space="preserve"><value>Actions</value></data>
	<data name="Yes" xml:space="preserve"><value>Yes</value></data>
	<data name="No" xml:space="preserve"><value>No</value></data>
	<data name="Block" xml:space="preserve"><value>Block</value></data>
	<data name="Unblock" xml:space="preserve"><value>Unblock</value></data>
	<data name="NoUsersFound" xml:space="preserve"><value>No users found.</value></data>
	<data name="AccessDenied" xml:space="preserve"><value>Access denied. Admin only.</value></data>
	<data name="UserActions" xml:space="preserve"><value>User Actions</value></data>
	<data name="ActionType" xml:space="preserve"><value>Action Type</value></data>
	<data name="All" xml:space="preserve"><value>All</value></data>
	<data name="Apply" xml:space="preserve"><value>Apply</value></data>
	<data name="User" xml:space="preserve"><value>User</value></data>
	<data name="Action" xml:space="preserve"><value>Action</value></data>
	<data name="Entity" xml:space="preserve"><value>Entity</value></data>
	<data name="When" xml:space="preserve"><value>When</value></data>
	<data name="NoActionsFound" xml:space="preserve"><value>No actions found.</value></data>
</root>
````

---

## FILE: `Blazor Web App/Resources/SharedResources.ru-RU.resx`

````text
﻿<?xml version="1.0" encoding="utf-8"?>
<root>
	<!-- 
		Microsoft ResX Schema

		Version 1.3

		The primary goals of this format is to allow a simple XML format 
		that is mostly human readable. The generation and parsing of the 
		various data types are done through the TypeConverter classes 
		associated with the data types.

		Example:

		... ado.net/XML headers & schema ...
		<resheader name="resmimetype">text/microsoft-resx</resheader>
		<resheader name="version">1.3</resheader>
		<resheader name="reader">System.Resources.ResXResourceReader, System.Windows.Forms, ...</resheader>
		<resheader name="writer">System.Resources.ResXResourceWriter, System.Windows.Forms, ...</resheader>
		<data name="Name1">this is my long string</data>
		<data name="Color1" type="System.Drawing.Color, System.Drawing">Blue</data>
		<data name="Bitmap1" mimetype="application/x-microsoft.net.object.binary.base64">
			[base64 mime encoded serialized .NET Framework object]
		</data>
		<data name="Icon1" type="System.Drawing.Icon, System.Drawing" mimetype="application/x-microsoft.net.object.bytearray.base64">
			[base64 mime encoded string representing a byte array form of the .NET Framework object]
		</data>

		There are any number of "resheader" rows that contain simple 
		name/value pairs.

		Each data row contains a name, and value. The row also contains a 
		type or mimetype. Type corresponds to a .NET class that support 
		text/value conversion through the TypeConverter architecture. 
		Classes that don't support this are serialized and stored with the 
		mimetype set.

		The mimetype is used for serialized objects, and tells the 
		ResXResourceReader how to depersist the object. This is currently not 
		extensible. For a given mimetype the value must be set accordingly:

		Note - application/x-microsoft.net.object.binary.base64 is the format 
		that the ResXResourceWriter will generate, however the reader can 
		read any of the formats listed below.

		mimetype: application/x-microsoft.net.object.binary.base64
		value   : The object must be serialized with 
			: System.Serialization.Formatters.Binary.BinaryFormatter
			: and then encoded with base64 encoding.

		mimetype: application/x-microsoft.net.object.soap.base64
		value   : The object must be serialized with 
			: System.Runtime.Serialization.Formatters.Soap.SoapFormatter
			: and then encoded with base64 encoding.

		mimetype: application/x-microsoft.net.object.bytearray.base64
		value   : The object must be serialized into a byte array 
			: using a System.ComponentModel.TypeConverter
			: and then encoded with base64 encoding.
	-->
	
	<xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata">
		<xsd:element name="root" msdata:IsDataSet="true">
			<xsd:complexType>
				<xsd:choice maxOccurs="unbounded">
					<xsd:element name="data">
						<xsd:complexType>
							<xsd:sequence>
								<xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
								<xsd:element name="comment" type="xsd:string" minOccurs="0" msdata:Ordinal="2" />
							</xsd:sequence>
							<xsd:attribute name="name" type="xsd:string" msdata:Ordinal="1" />
							<xsd:attribute name="type" type="xsd:string" msdata:Ordinal="3" />
							<xsd:attribute name="mimetype" type="xsd:string" msdata:Ordinal="4" />
						</xsd:complexType>
					</xsd:element>
					<xsd:element name="resheader">
						<xsd:complexType>
							<xsd:sequence>
								<xsd:element name="value" type="xsd:string" minOccurs="0" msdata:Ordinal="1" />
							</xsd:sequence>
							<xsd:attribute name="name" type="xsd:string" use="required" />
						</xsd:complexType>
					</xsd:element>
				</xsd:choice>
			</xsd:complexType>
		</xsd:element>
	</xsd:schema>
	<resheader name="resmimetype">
		<value>text/microsoft-resx</value>
	</resheader>
	<resheader name="version">
		<value>1.3</value>
	</resheader>
	<resheader name="reader">
		<value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=2.0.3500.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
	</resheader>
	<resheader name="writer">
		<value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=2.0.3500.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
	</resheader>
	<data name="AppName" xml:space="preserve"><value>Биржа заданий</value></data>
	<data name="SignIn" xml:space="preserve"><value>Войти</value></data>
	<data name="SignOut" xml:space="preserve"><value>Выйти</value></data>
	<data name="Register" xml:space="preserve"><value>Регистрация</value></data>
	<data name="AdminUsers" xml:space="preserve"><value>Админ: Пользователи</value></data>
	<data name="AdminActions" xml:space="preserve"><value>Админ: Действия</value></data>
	<data name="MyTasks" xml:space="preserve"><value>Мои задачи</value></data>
	<data name="BrowseTasks" xml:space="preserve"><value>Поиск задач</value></data>
	<data name="MyAssigned" xml:space="preserve"><value>Назначенные мне</value></data>

	<data name="Hello" xml:space="preserve"><value>Привет</value></data>
	<data name="QuickActions" xml:space="preserve"><value>Быстрые действия</value></data>
	<data name="ManageMyTasks" xml:space="preserve"><value>Управляйте своими задачами, просматривайте кандидатов и выбирайте исполнителя.</value></data>
	<data name="OpenTasks" xml:space="preserve"><value>Мои задачи</value></data>
	<data name="FindTasks" xml:space="preserve"><value>Найдите новые задачи и откликайтесь на них.</value></data>
	<data name="Browse" xml:space="preserve"><value>Поиск</value></data>
	<data name="TasksAssigned" xml:space="preserve"><value>Задачи, назначенные вам, чаты с заказчиками и дедлайны.</value></data>
	<data name="OpenAssigned" xml:space="preserve"><value>Назначенные</value></data>
	<data name="ManageUsers" xml:space="preserve"><value>Управление пользователями, ролями, блокировками и удалением.</value></data>
	<data name="OpenUsers" xml:space="preserve"><value>Пользователи</value></data>
	<data name="ViewLog" xml:space="preserve"><value>Просмотр журнала действий с фильтрами.</value></data>
	<data name="OpenLog" xml:space="preserve"><value>Журнал</value></data>

	<data name="NewTask" xml:space="preserve"><value>+ Новая задача</value></data>
	<data name="SearchPlaceholder" xml:space="preserve"><value>Поиск по названию...</value></data>
	<data name="Search" xml:space="preserve"><value>Найти</value></data>
	<data name="Clear" xml:space="preserve"><value>Очистить</value></data>
	<data name="NoTasksFound" xml:space="preserve"><value>Задачи не найдены.</value></data>
	<data name="ViewCandidates" xml:space="preserve"><value>Кандидаты</value></data>
	<data name="Prev" xml:space="preserve"><value>Назад</value></data>
	<data name="Next" xml:space="preserve"><value>Вперёд</value></data>
	<data name="AvailableTasks" xml:space="preserve"><value>Доступные задачи</value></data>
	<data name="MyAssignedTasks" xml:space="preserve"><value>Назначенные задачи</value></data>
	<data name="NoAssignedTasks" xml:space="preserve"><value>Назначенных задач нет.</value></data>

	<data name="Respond" xml:space="preserve"><value>Откликнуться</value></data>
	<data name="Responded" xml:space="preserve"><value>Отклик отправлен</value></data>
	<data name="Chat" xml:space="preserve"><value>Чат</value></data>
	<data name="Done" xml:space="preserve"><value>Готово</value></data>
	<data name="Edit" xml:space="preserve"><value>Редактировать</value></data>
	<data name="Cancel" xml:space="preserve"><value>Отменить</value></data>
	<data name="Attachments" xml:space="preserve"><value>Вложения</value></data>

	<data name="UploadFile" xml:space="preserve"><value>Загрузить файл</value></data>
	<data name="MaxSizeLabel" xml:space="preserve"><value>(макс. {0} МБ)</value></data>
	<data name="NoAttachments" xml:space="preserve"><value>Вложений пока нет.</value></data>
	<data name="Download" xml:space="preserve"><value>Скачать</value></data>
	<data name="Delete" xml:space="preserve"><value>Удалить</value></data>
	<data name="Close" xml:space="preserve"><value>Закрыть</value></data>

	<data name="ChatTitle" xml:space="preserve"><value>Чат</value></data>
	<data name="NoMessages" xml:space="preserve"><value>Сообщений пока нет</value></data>
	<data name="MessagePlaceholder" xml:space="preserve"><value>Сообщение...</value></data>
	<data name="Send" xml:space="preserve"><value>Отправить</value></data>
	<data name="You" xml:space="preserve"><value>Вы</value></data>

	<data name="CreateTask" xml:space="preserve"><value>Новая задача</value></data>
	<data name="EditTask" xml:space="preserve"><value>Редактирование задачи</value></data>
	<data name="Title" xml:space="preserve"><value>Название</value></data>
	<data name="Description" xml:space="preserve"><value>Описание</value></data>
	<data name="Price" xml:space="preserve"><value>Цена</value></data>
	<data name="Start" xml:space="preserve"><value>Начало</value></data>
	<data name="End" xml:space="preserve"><value>Конец</value></data>
	<data name="Create" xml:space="preserve"><value>Создать</value></data>
	<data name="Save" xml:space="preserve"><value>Сохранить</value></data>

	<data name="CandidatesFor" xml:space="preserve"><value>Кандидаты на</value></data>
	<data name="NoCandidates" xml:space="preserve"><value>Кандидатов пока нет.</value></data>
	<data name="RespondedAt" xml:space="preserve"><value>Откликнулся:</value></data>
	<data name="Assign" xml:space="preserve"><value>Назначить</value></data>

	<data name="Rate" xml:space="preserve"><value>Оценка</value></data>
	<data name="SelectRating" xml:space="preserve"><value>Выберите оценку ({0}–{1}):</value></data>
	<data name="Skip" xml:space="preserve"><value>Пропустить</value></data>
	<data name="Submit" xml:space="preserve"><value>Отправить</value></data>

	<data name="Login" xml:space="preserve"><value>Логин</value></data>
	<data name="Password" xml:space="preserve"><value>Пароль</value></data>
	<data name="Loading" xml:space="preserve"><value>Загрузка...</value></data>
	<data name="NoAccount" xml:space="preserve"><value>Нет аккаунта? Зарегистрироваться</value></data>
	<data name="LoggedInSuccess" xml:space="preserve"><value>Вход выполнен!</value></data>
	<data name="RegisteredSuccess" xml:space="preserve"><value>Регистрация прошла успешно!</value></data>
	<data name="Customer" xml:space="preserve"><value>Заказчик</value></data>
	<data name="Executor" xml:space="preserve"><value>Исполнитель</value></data>

	<data name="Users" xml:space="preserve"><value>Пользователи</value></data>
	<data name="Name" xml:space="preserve"><value>Имя</value></data>
	<data name="Role" xml:space="preserve"><value>Роль</value></data>
	<data name="Rating" xml:space="preserve"><value>Рейтинг</value></data>
	<data name="Blocked" xml:space="preserve"><value>Заблокирован</value></data>
	<data name="Actions" xml:space="preserve"><value>Действия</value></data>
	<data name="Yes" xml:space="preserve"><value>Да</value></data>
	<data name="No" xml:space="preserve"><value>Нет</value></data>
	<data name="Block" xml:space="preserve"><value>Заблокировать</value></data>
	<data name="Unblock" xml:space="preserve"><value>Разблокировать</value></data>
	<data name="NoUsersFound" xml:space="preserve"><value>Пользователи не найдены.</value></data>
	<data name="AccessDenied" xml:space="preserve"><value>Доступ запрещён. Только для админа.</value></data>
	<data name="UserActions" xml:space="preserve"><value>Действия пользователей</value></data>
	<data name="ActionType" xml:space="preserve"><value>Тип действия</value></data>
	<data name="All" xml:space="preserve"><value>Все</value></data>
	<data name="Apply" xml:space="preserve"><value>Применить</value></data>
	<data name="User" xml:space="preserve"><value>Пользователь</value></data>
	<data name="Action" xml:space="preserve"><value>Действие</value></data>
	<data name="Entity" xml:space="preserve"><value>Сущность</value></data>
	<data name="When" xml:space="preserve"><value>Когда</value></data>
	<data name="NoActionsFound" xml:space="preserve"><value>Действий не найдено.</value></data>
</root>
````

---

## FILE: `Blazor Web App/Services/Culture/CultureService.cs`

````csharp
﻿using Blazor_Web_App.Constants;
using Blazor_Web_App.Services.Culture;
using Blazor_Web_App.Services.LocalStorage;
using System.Globalization;

namespace Blazor_Web_App.Services;

public class CultureService(
    ILocalStorageService _storage) : ICultureService
{
    public async Task<string> GetCultureAsync()
    {
        var value = await _storage.GetItemAsync(CultureConstants.StorageKey);

        return string.IsNullOrWhiteSpace(value)
            ? CultureConstants.Default
            : value;
    }

    public async Task SetCultureAsync(string culture)
    {
        if (!CultureConstants.Supported.Contains(culture))
        {
            culture = CultureConstants.Default;
        }

        await _storage.SetItemAsync(CultureConstants.StorageKey, culture);
    }

    public void Apply(string culture)
    {
        if (!CultureConstants.Supported.Contains(culture))
        {
            culture = CultureConstants.Default;
        }

        var cultureInfo = new CultureInfo(culture);

        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
    }
}
````

---

## FILE: `Blazor Web App/Services/Culture/ICultureService.cs`

````csharp
﻿namespace Blazor_Web_App.Services.Culture;

public interface ICultureService
{
    Task<string> GetCultureAsync();

    Task SetCultureAsync(string culture);

    void Apply(string culture);
}
````

---

## FILE: `Blazor Web App/Services/CustomAuthStateProvider.cs`

````csharp
﻿using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Shared.Dtos.Responses.Users;
using System.Security.Claims;

namespace Blazor_Web_App.Services;

public class CustomAuthStateProvider(
    ILocalStorageService _localStorage) : AuthenticationStateProvider
{
    private const string AuthenticationType = "jwt";

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        try
        {
            var token = await _localStorage.GetItemAsync(nameof(AuthDto.Token));

            if (string.IsNullOrEmpty(token))
            {
                return new AuthenticationState(
                    new ClaimsPrincipal(
                        new ClaimsIdentity()));
            }

            var name = await _localStorage.GetItemAsync(nameof(AuthDto.Name));
            var role = await _localStorage.GetItemAsync(nameof(AuthDto.Role));
            var id = await _localStorage.GetItemAsync(nameof(AuthDto.Id));

            var identity = CreateClaimsIdentity(name!, role!, id!);

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
        catch
        {
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
    }

    public void NotifyLogin(
        string name,
        string role,
        string id)
    {
        var identity = CreateClaimsIdentity(name, role, id);

        NotifyWithIdentityOrDefault(identity);
    }

    public void NotifyLogout()
    {
        NotifyWithIdentityOrDefault();
    }

    private void NotifyWithIdentityOrDefault(ClaimsIdentity? identity = null)
    {
        if (identity is null)
        {
            identity = new ClaimsIdentity();
        }

        NotifyAuthenticationStateChanged(
            Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
    }

    private ClaimsIdentity CreateClaimsIdentity(string name, string role, string userId)
    {
        var identity = new ClaimsIdentity(
        [
            new Claim(ClaimTypes.NameIdentifier, userId),
            new Claim(ClaimTypes.Name, name),
            new Claim(ClaimTypes.Role, role)
        ], AuthenticationType);

        return identity;
    }
}
````

---

## FILE: `Blazor Web App/Services/LocalStorage/ILocalStorageService.cs`

````csharp
﻿namespace Blazor_Web_App.Services.LocalStorage;

public interface ILocalStorageService
{
    Task SetItemAsync(string key, string value);

    Task<string?> GetItemAsync(string key);

    Task RemoveItemAsync(string key);
}
````

---

## FILE: `Blazor Web App/Services/LocalStorage/LocalStorageService.cs`

````csharp
﻿using Microsoft.JSInterop;

namespace Blazor_Web_App.Services.LocalStorage;

public class LocalStorageService(
    IJSRuntime _jsRuntime) : ILocalStorageService
{
    private const string localStorageSetItem = "localStorage.setItem";
    private const string localStorageGetItem = "localStorage.getItem";
    private const string localStorageRemoveItem = "localStorage.removeItem";

    public async Task SetItemAsync(string key, string value)
    {
        await _jsRuntime.InvokeVoidAsync(localStorageSetItem, key, value);
    }

    public async Task<string?> GetItemAsync(string key)
    {
        var result = await _jsRuntime.InvokeAsync<string?>(localStorageGetItem, key);

        return result;
    }
    public async Task RemoveItemAsync(string key)
    {
        await _jsRuntime.InvokeVoidAsync(localStorageRemoveItem, key);
    }
}
````

---

## FILE: `Blazor Web App/Services/Receivers/Auth/AuthService.cs`

````csharp
﻿using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Services.Receivers.Auth;

public class AuthService(
    HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IAuthService
{
    public async Task<Result<AuthDto>> RegisterAsync(
        RegisterUserDto registerUserDto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            "register",
            registerUserDto,
            cancellationToken);

        var result = await HandleResponseAsync<AuthDto>(response, cancellationToken);

        return result;
    }

    public async Task<Result<AuthDto>> LoginAsync(
        LoginDto loginDto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            "login",
            loginDto,
            cancellationToken);

        var result = await HandleResponseAsync<AuthDto>(response, cancellationToken);

        return result;
    }
}
````

---

## FILE: `Blazor Web App/Services/Receivers/Auth/IAuthService.cs`

````csharp
﻿using Shared.Dtos.Requests.Users;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;

namespace Blazor_Web_App.Services.Receivers.Auth;

public interface IAuthService
{
    Task<Result<AuthDto>> RegisterAsync(RegisterUserDto registerUserDto, CancellationToken cancellationToken = default);

    Task<Result<AuthDto>> LoginAsync(LoginDto loginDto, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Blazor Web App/Services/Receivers/BaseService.cs`

````csharp
﻿using Blazor_Web_App.Constants;
using Blazor_Web_App.Services.LocalStorage;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using System.Net.Http.Headers;
using System.Text.Json;

namespace Blazor_Web_App.Services.Receivers;

public abstract class BaseService
{
    protected HttpClient _httpClient { get; private set; }
    protected ILocalStorageService _localStorage { get; private set; }

    private const string Scheme = "Bearer";
    protected const int FirstPageNumber = Pagination.FirstPage;
    protected const int BasePageSize = Pagination.DefaultPageSize;

    private readonly JsonSerializerOptions _options = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    };

    protected BaseService(
        HttpClient httpClient,
        ILocalStorageService localStorage)
    {
        _httpClient = httpClient;
        _localStorage = localStorage;
    }

    protected async Task SetAuthHeaderAsync(
        CancellationToken cancellationToken = default)
    {
        var token = await _localStorage
            .GetItemAsync(nameof(AuthDto.Token));

        if (!string.IsNullOrEmpty(token))
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(Scheme, token);
        }
    }

    protected async Task<Result<T>> HandleResponseAsync<T>(
    HttpResponseMessage response,
    CancellationToken cancellationToken = default) where T : class
    {
        if (!response.IsSuccessStatusCode)
        {
            var problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result<T>.Failure(problemDetails!.Detail! ?? ServiceMessages.UnknownServerError);
        }

        if (response.Content.Headers.ContentLength == AttachmentConstants.Zero)
        {
            return Result<T>.Failure(ServiceMessages.EmptyResponse);
        }

        var dto = await response.Content.ReadFromJsonAsync<T>(
            _options,
            cancellationToken);

        if (dto is null)
        {
            return Result<T>.Failure(ServiceMessages.DeserializationFailed);
        }

        return Result<T>.Success(dto!);
    }

    protected async Task<Result> HandleResponseAsync(
       HttpResponseMessage response,
       CancellationToken cancellationToken = default)
    {
        if (!response.IsSuccessStatusCode)
        {
            var problemDetails = await response.Content.ReadFromJsonAsync<ProblemDetails>(cancellationToken);

            return Result.Failure(problemDetails!.Detail! ?? ServiceMessages.UnknownServerError);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Blazor Web App/Services/Receivers/Chats/ChatService.cs`

````csharp
﻿using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Blazor_Web_App.Services.Receivers.Chats;

public class ChatService(
    HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IChatService
{
    public async Task<Result<ChatDto>> CreateChatAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"?projectTaskId={taskId}",
            null,
            cancellationToken);

        var result = await HandleResponseAsync<ChatDto>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result<ChatDto>> GetChatByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"task/{taskId}",
            cancellationToken);

        var result = await HandleResponseAsync<ChatDto>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> SendMessageAsync(
        Guid chatId,
        string text,
        Guid senderId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new
        {
            Text = text
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"{chatId}/messages",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }
}
````

---

## FILE: `Blazor Web App/Services/Receivers/Chats/IChatService.cs`

````csharp
﻿using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Chats;

namespace Blazor_Web_App.Services.Receivers.Chats;

public interface IChatService
{
    Task<Result<ChatDto>> CreateChatAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result<ChatDto>> GetChatByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result> SendMessageAsync(Guid chatId, string text, Guid senderId, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Blazor Web App/Services/Receivers/ProjectTasks/IProjectTaskService.cs`

````csharp
﻿using Blazor_Web_App.Constants;
using Shared.Dtos.Requests.ProjectTasks;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Services.Receivers.ProjectTasks;

public interface IProjectTaskService
{
    Task<Result<PagedResult<ProjectTaskDto>>> GetMyTasksAsync(Guid customerId, int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result<ProjectTaskDto>> CreateTaskAsync(CreateProjectTaskDto dto, CancellationToken cancellationToken = default);

    Task<Result> DeleteTaskAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Result<PagedResult<ProjectTaskDto>>> GetPublishedTasksAsync(int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result> RespondToTaskAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result<List<TaskResponseDto>>> GetTaskResponsesAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result> AssignExecutorAsync(Guid taskId, Guid executorId, CancellationToken cancellationToken = default);

    Task<Result<PagedResult<ProjectTaskDto>>> GetAssignedTasksAsync(Guid executorId, int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result<ProjectTaskDto>> GetTaskByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Result> CancelTaskAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result> MarkAsDoneAsync(Guid taskId, decimal? rating, CancellationToken cancellationToken = default);

    Task<Result<PagedResult<ProjectTaskDto>>> SearchTasksAsync(string query, int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result> UpdateTaskAsync(Guid id, UpdateProjectTaskDto dto, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Blazor Web App/Services/Receivers/ProjectTasks/ProjectTaskService.cs`

````csharp
﻿using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Requests.ProjectTasks;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Services.Receivers.ProjectTasks;

public class ProjectTaskService(
    HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IProjectTaskService
{
    public async Task<Result<PagedResult<ProjectTaskDto>>> GetMyTasksAsync(
        Guid customerId,
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"customer/{customerId}?page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<ProjectTaskDto>>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<ProjectTaskDto>> CreateTaskAsync(
        CreateProjectTaskDto dto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsJsonAsync(
            string.Empty,
            dto,
            cancellationToken);

        var result = await HandleResponseAsync<ProjectTaskDto>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result> DeleteTaskAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.DeleteAsync(
            $"{id}",
            cancellationToken);

        var result = await HandleResponseAsync(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> GetPublishedTasksAsync(
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"published?page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<ProjectTaskDto>>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result> RespondToTaskAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"{taskId}/respond",
            null,
            cancellationToken);

        var result = await HandleResponseAsync(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<List<TaskResponseDto>>> GetTaskResponsesAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"{taskId}/responses",
            cancellationToken);

        var result = await HandleResponseAsync<List<TaskResponseDto>>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> AssignExecutorAsync(
        Guid taskId,
        Guid executorId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new
        {
            ExecutorId = executorId.ToString()
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"{taskId}/assign",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
            response,
            cancellationToken);

        return result;
    }


    public async Task<Result<PagedResult<ProjectTaskDto>>> GetAssignedTasksAsync(
        Guid executorId,
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"assigned/{executorId}?page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<ProjectTaskDto>>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result<ProjectTaskDto>> GetTaskByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"{id}",
            cancellationToken);

        var result = await HandleResponseAsync<ProjectTaskDto>(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> CancelTaskAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"{taskId}/cancel",
            null,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> MarkAsDoneAsync(
        Guid taskId,
        decimal? rating,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new
        {
            Rating = rating
        };

        var response = await _httpClient.PostAsJsonAsync(
            $"{taskId}/mark-as-done",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result<PagedResult<ProjectTaskDto>>> SearchTasksAsync(
        string query,
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"search?query={Uri.EscapeDataString(query)}&page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<ProjectTaskDto>>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result> UpdateTaskAsync(
        Guid id,
        UpdateProjectTaskDto dto,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PutAsJsonAsync(
            $"{id}",
            dto,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }
}
````

---

## FILE: `Blazor Web App/Services/Receivers/TaskAttachments/ITaskAttachmentService.cs`

````csharp
﻿using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Services.Receivers.TaskAttachments;

public interface ITaskAttachmentService
{
    Task<Result<List<TaskAttachmentDto>>> GetTaskAttachmentsAsync(Guid taskId, CancellationToken cancellationToken = default);

    Task<Result<TaskAttachmentDto>> UploadAttachmentAsync(Guid taskId, Stream content, string fileName, string contentType, CancellationToken cancellationToken = default);

    Task<Result> DeleteAttachmentAsync(Guid taskId, Guid attachmentId, CancellationToken cancellationToken = default);

    Task<Result<AttachmentFileResult>> DownloadAttachmentAsync(Guid taskId, Guid attachmentId, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Blazor Web App/Services/Receivers/TaskAttachments/TaskAttachmentService.cs`

````csharp
﻿using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using System.Net.Http.Headers;

namespace Blazor_Web_App.Services.Receivers.TaskAttachments;

public class TaskAttachmentService(
    HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), ITaskAttachmentService
{
    public async Task<Result<List<TaskAttachmentDto>>> GetTaskAttachmentsAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"{taskId}/attachments",
            cancellationToken);

        var result = await HandleResponseAsync<List<TaskAttachmentDto>>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<TaskAttachmentDto>> UploadAttachmentAsync(
        Guid taskId,
        Stream content,
        string fileName,
        string contentType,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        using var form = new MultipartFormDataContent();

        using var fileContent = new StreamContent(content);

        fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);

        form.Add(fileContent, "file", fileName);

        var response = await _httpClient.PostAsync(
            $"{taskId}/attachments",
            form,
            cancellationToken);

        var result = await HandleResponseAsync<TaskAttachmentDto>(
            response,
            cancellationToken);

        return result;

    }

    public async Task<Result> DeleteAttachmentAsync(
        Guid taskId,
        Guid attachmentId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.DeleteAsync(
            $"{taskId}/attachments/{attachmentId}",
            cancellationToken);

        var result = await HandleResponseAsync(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<AttachmentFileResult>> DownloadAttachmentAsync(
        Guid taskId,
        Guid attachmentId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"{taskId}/attachments/{attachmentId}/download",
            cancellationToken);

        var result = await HandleResponseAsync<AttachmentFileResult>(
           response,
           cancellationToken);

        return result;
    }
}
````

---

## FILE: `Blazor Web App/Services/Receivers/UserActions/IUserActionService.cs`

````csharp
﻿using Blazor_Web_App.Constants;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Blazor_Web_App.Services.Receivers.UserActions;

public interface IUserActionService
{
    Task<Result<PagedResult<UserActionDto>>> GetUserActionsAsync(Guid? userId, int? actionType, int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Blazor Web App/Services/Receivers/UserActions/UserActionService.cs`

````csharp
﻿using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.UserActions;

namespace Blazor_Web_App.Services.Receivers.UserActions;

public class UserActionService(HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IUserActionService
{
    public async Task<Result<PagedResult<UserActionDto>>> GetUserActionsAsync(
        Guid? userId,
        int? actionType,
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var url = $"?page={page}&pageSize={pageSize}";

        if (userId.HasValue)
        {
            url += $"&userId={userId.Value}";
        }

        if (actionType.HasValue)
        {
            url += $"&actionType={actionType.Value}";
        }

        var response = await _httpClient.GetAsync(url, cancellationToken);

        var result = await HandleResponseAsync<PagedResult<UserActionDto>>(
          response,
          cancellationToken);

        return result;
    }


}
````

---

## FILE: `Blazor Web App/Services/Receivers/Users/IUserService.cs`

````csharp
﻿using Blazor_Web_App.Constants;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Blazor_Web_App.Services.Receivers.Users;

public interface IUserService
{
    Task<Result<PagedResult<UserDto>>> GetUsersAsync(int page = Pagination.FirstPage, int pageSize = Pagination.DefaultPageSize, CancellationToken cancellationToken = default);

    Task<Result> ChangeRoleAsync(Guid userId, UserRole newRole, CancellationToken cancellationToken = default);

    Task<Result> BlockUserAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<Result> UnblockUserAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<Result> DeleteUserAsync(Guid userId, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Blazor Web App/Services/Receivers/Users/UserService.cs`

````csharp
﻿using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.Users;
using Shared.Enums;

namespace Blazor_Web_App.Services.Receivers.Users;

public class UserService(HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), IUserService
{
    public async Task<Result<PagedResult<UserDto>>> GetUsersAsync(
        int page = FirstPageNumber,
        int pageSize = BasePageSize,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"?page={page}&pageSize={pageSize}",
            cancellationToken);

        var result = await HandleResponseAsync<PagedResult<UserDto>>(
          response,
          cancellationToken);

        return result;
    }

    public async Task<Result> ChangeRoleAsync(
        Guid userId,
        UserRole newRole,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var body = new { NewRole = newRole };

        var response = await _httpClient.PatchAsJsonAsync(
            $"{userId}/role",
            body,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> BlockUserAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"{userId}/block",
            null,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> UnblockUserAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.PostAsync(
            $"{userId}/unblock",
            null,
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }

    public async Task<Result> DeleteUserAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.DeleteAsync(
            $"{userId}",
            cancellationToken);

        var result = await HandleResponseAsync(
           response,
           cancellationToken);

        return result;
    }
}
````

---

## FILE: `Blazor Web App/Settings/ApiSettings.cs`

````csharp
﻿using System.ComponentModel.DataAnnotations;

namespace Blazor_Web_App.Settings;

public class ApiSettings
{
    public static string SectionName { get; set; } = nameof(ApiSettings);

    [Required(ErrorMessage = "Api Url must be setted before start up")]
    public string ApiUrl { get; set; } = string.Empty;
}
````

---

## FILE: `Blazor Web App/wwwroot/app.css`

````css
html, body {
    font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif;
}

a, .btn-link {
    color: #006bb7;
}

.btn-primary {
    color: #fff;
    background-color: #1b6ec2;
    border-color: #1861ac;
}

.btn:focus, .btn:active:focus, .btn-link.nav-link:focus, .form-control:focus, .form-check-input:focus {
  box-shadow: 0 0 0 0.1rem white, 0 0 0 0.25rem #258cfb;
}

.content {
    padding-top: 1.1rem;
}

h1:focus {
    outline: none;
}

.valid.modified:not([type=checkbox]) {
    outline: 1px solid #26b050;
}

.invalid {
    outline: 1px solid #e50000;
}

.validation-message {
    color: #e50000;
}

.blazor-error-boundary {
    background: url(data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNTYiIGhlaWdodD0iNDkiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIG92ZXJmbG93PSJoaWRkZW4iPjxkZWZzPjxjbGlwUGF0aCBpZD0iY2xpcDAiPjxyZWN0IHg9IjIzNSIgeT0iNTEiIHdpZHRoPSI1NiIgaGVpZ2h0PSI0OSIvPjwvY2xpcFBhdGg+PC9kZWZzPjxnIGNsaXAtcGF0aD0idXJsKCNjbGlwMCkiIHRyYW5zZm9ybT0idHJhbnNsYXRlKC0yMzUgLTUxKSI+PHBhdGggZD0iTTI2My41MDYgNTFDMjY0LjcxNyA1MSAyNjUuODEzIDUxLjQ4MzcgMjY2LjYwNiA1Mi4yNjU4TDI2Ny4wNTIgNTIuNzk4NyAyNjcuNTM5IDUzLjYyODMgMjkwLjE4NSA5Mi4xODMxIDI5MC41NDUgOTIuNzk1IDI5MC42NTYgOTIuOTk2QzI5MC44NzcgOTMuNTEzIDI5MSA5NC4wODE1IDI5MSA5NC42NzgyIDI5MSA5Ny4wNjUxIDI4OS4wMzggOTkgMjg2LjYxNyA5OUwyNDAuMzgzIDk5QzIzNy45NjMgOTkgMjM2IDk3LjA2NTEgMjM2IDk0LjY3ODIgMjM2IDk0LjM3OTkgMjM2LjAzMSA5NC4wODg2IDIzNi4wODkgOTMuODA3MkwyMzYuMzM4IDkzLjAxNjIgMjM2Ljg1OCA5Mi4xMzE0IDI1OS40NzMgNTMuNjI5NCAyNTkuOTYxIDUyLjc5ODUgMjYwLjQwNyA1Mi4yNjU4QzI2MS4yIDUxLjQ4MzcgMjYyLjI5NiA1MSAyNjMuNTA2IDUxWk0yNjMuNTg2IDY2LjAxODNDMjYwLjczNyA2Ni4wMTgzIDI1OS4zMTMgNjcuMTI0NSAyNTkuMzEzIDY5LjMzNyAyNTkuMzEzIDY5LjYxMDIgMjU5LjMzMiA2OS44NjA4IDI1OS4zNzEgNzAuMDg4N0wyNjEuNzk1IDg0LjAxNjEgMjY1LjM4IDg0LjAxNjEgMjY3LjgyMSA2OS43NDc1QzI2Ny44NiA2OS43MzA5IDI2Ny44NzkgNjkuNTg3NyAyNjcuODc5IDY5LjMxNzkgMjY3Ljg3OSA2Ny4xMTgyIDI2Ni40NDggNjYuMDE4MyAyNjMuNTg2IDY2LjAxODNaTTI2My41NzYgODYuMDU0N0MyNjEuMDQ5IDg2LjA1NDcgMjU5Ljc4NiA4Ny4zMDA1IDI1OS43ODYgODkuNzkyMSAyNTkuNzg2IDkyLjI4MzcgMjYxLjA0OSA5My41Mjk1IDI2My41NzYgOTMuNTI5NSAyNjYuMTE2IDkzLjUyOTUgMjY3LjM4NyA5Mi4yODM3IDI2Ny4zODcgODkuNzkyMSAyNjcuMzg3IDg3LjMwMDUgMjY2LjExNiA4Ni4wNTQ3IDI2My41NzYgODYuMDU0N1oiIGZpbGw9IiNGRkU1MDAiIGZpbGwtcnVsZT0iZXZlbm9kZCIvPjwvZz48L3N2Zz4=) no-repeat 1rem/1.8rem, #b32121;
    padding: 1rem 1rem 1rem 3.7rem;
    color: white;
}

    .blazor-error-boundary::after {
        content: "An error has occurred."
    }

.darker-border-checkbox.form-check-input {
    border-color: #929292;
}

.form-floating > .form-control-plaintext::placeholder, .form-floating > .form-control::placeholder {
    color: var(--bs-secondary-color);
    text-align: end;
}

.form-floating > .form-control-plaintext:focus::placeholder, .form-floating > .form-control:focus::placeholder {
    text-align: start;
}
````

---

## FILE: `Blazor Web App/wwwroot/download.js`

````javascript
﻿window.downloadFileFromBytes = (fileName, contentType, bytes) => {
    const blob = new Blob(
        [new Uint8Array(bytes)],
        { type: contentType || 'application/octet-stream' });

    const url = URL.createObjectURL(blob);

    const a = document.createElement('a');
    a.href = url;
    a.download = fileName;
    document.body.appendChild(a);
    a.click();

    document.body.removeChild(a);
    URL.revokeObjectURL(url);
};
````

---

## FILE: `blazor.dockerfile`

````text
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY ["Blazor Web App/", "Blazor Web App/"]
COPY ["Shared/", "Shared/"]
RUN dotnet restore "Blazor Web App/Blazor Web App.csproj"
WORKDIR "/src/Blazor Web App"
RUN dotnet publish "Blazor Web App.csproj" -c Release -o "/app/dlls"

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR "/app"
COPY --from=build "/app/dlls" .
ENTRYPOINT ["dotnet", "Blazor_Web_App.dll"]
````

---

## FILE: `docker-compose.yml`

````yaml
version: '3.8'

services:
  sqlserver:
    image: mcr.microsoft.com/mssql/server:2022-latest
    container_name: projecttask-sqlserver
    environment:
      - ACCEPT_EULA=Y
      - SA_PASSWORD=${AppConfig__Password}
      - MSSQL_PID=Developer
    ports:
      - "1433:1433"
    volumes:
      - sqlserver-data:/var/opt/mssql
    healthcheck:
        test: ["CMD-SHELL", "/opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P '${AppConfig__Password}' -C -Q 'SELECT 1' || exit 1"]
        interval: 10s
        timeout: 5s
        retries: 10
        start_period: 20s
    env_file:
      - .env
        
  web_api:
    build:
        context: .
        dockerfile: wep-api.dockerfile
    ports:
        - "7025:8080"
    depends_on:
        sqlserver:
            condition: service_healthy
    environment:
        - ASPNETCORE_ENVIRONMENT=Development
    env_file:
      - .env 
      
  blazor_client:
    build:
      context: .
      dockerfile: blazor.dockerfile
    container_name: projecttask-client
    ports:
      - "5020:8080"
    depends_on:
      - web_api
    environment:
      - ASPNETCORE_ENVIRONMENT=Development
      - ApiSettings__ApiUrl=http://web_api:8080
    env_file:
      - .env
    
  blazor_other_client:
    build:
      context: .
      dockerfile: blazor.dockerfile
    container_name: projecttask-other-client
    ports:
      - "5021:8080"
    depends_on:
      - web_api
    environment:
      - ASPNETCORE_ENVIRONMENT=Development
      - ApiSettings__ApiUrl=http://web_api:8080 
    env_file:
      - .env

volumes:
  sqlserver-data:
````

---

## FILE: `Domain/Config/AppConfig.cs`

````csharp
﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Config;

public class AppConfig : IConfigSection
{
    public static string SectionName { get; set; } = nameof(AppConfig);

    public string AppName { get; set; } = "Task Marketplace";
    [Required(ErrorMessage = "Connection string must be set to start an app")]
    public string ConnectionString { get; set; } = string.Empty;
    public string Currency { get; set; } = "$";
}
````

---

## FILE: `Domain/Config/FileStorage.cs`

````csharp
﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Config;

public class FileSettings : IConfigSection
{
    public static string SectionName { get; set; } = nameof(FileSettings);


    [Required(ErrorMessage = "File name must be set to start an app")]
    public string FileName { get; set; } = string.Empty;
    public string FullPath { get; set; } = string.Empty;
}
````

---

## FILE: `Domain/Config/IConfigSection.cs`

````csharp
﻿namespace Domain.Config;

public interface IConfigSection
{
    static abstract string SectionName { get; }
}
````

---

## FILE: `Domain/Config/JwtSettings.cs`

````csharp
﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Config;

public class JwtSettings : IConfigSection
{
    public static string SectionName { get; set; } = nameof(JwtSettings);

    [Required(ErrorMessage = "Key must be set to start an app")]
    public string Key { get; set; } = string.Empty;
    [Required(ErrorMessage = "Valid issuer must be set to start an app")]
    public string[] ValidIssuers { get; set; } = [];
    [Required(ErrorMessage = "Valid audience must be set to start an app")]
    public string[] ValidAudiences { get; set; } = [];
    [Required(ErrorMessage = "Valid expires hours must be set to start an app")]
    public int ExpiresHours { get; set; } = 2;
}
````

---

## FILE: `Domain/Constants/AttachmentConstants.cs`

````csharp
﻿namespace Domain.Constants;

public static class AttachmentConstants
{
    public const long MinSizeBytes = 0;
    public const long MaxSizeBytes = 50L * 1024 * 1024;
    public const string DefaultContentType = "application/octet-stream";
}
````

---

## FILE: `Domain/Constants/CurrencyConstants.cs`

````csharp
﻿namespace Domain.Constants;

public static class CurrencyConstants
{
    public const decimal BasePrice = 0.0m;

    public const int MinPage = 1;
    public const int OffsetPage = 1;

    public const int ZeroElements = 0;

}
````

---

## FILE: `Domain/Constants/ErrorMessages.cs`

````csharp
﻿namespace Domain.Constants;

public static class ErrorMessages
{
    public const string EntityHasAlreadyDeleted = "Entity has alredy deleted";

    public const string TitleCannotBeEmpty = "Title can't be empty";
    public const string DescriptionCannotBeEmpty = "Description can't be empty";
    public const string PriceConnotBeNegative = "Price must be greater than 0";
    public const string FutureDateTime = "StartsAt and EndsAt must be in the future";
    public const string EndDateMustBeAfterStartDate = "End date must be after start date";

    public const string PasswordCannotBeEmpty = "User password can't be empty";
    public const string PasswordHashCannotBeEmpty = "User passwordhash can't be empty";
    public const string UserNameCannotBeEmpty = "User name can't be empty";
    public const string CannotEditInThisStatus = "Can't edit in progress/done/cancelled";
    public const string CustomerMustBeSame = "Customer must be same";
    public const string OnlyCustomerCanAssign = "Only customer can assign to project task";
    public const string AdminRoleCannotSetup = "Admin role cannot setup";

    public const string ProjectMustBeInProgress = "Project must be in progress to do done";
    public const string OnlyPublishedTaskCanBeAssigned = "Only a published task can be assigned";
    public const string MustBePublishedToRespond = "Project task must be published to respond";
    public const string CustomerCannotRespond = "Customer cannot respond to his own project task";

    public const string MessageTextCannotBeEmpty = "Message text cannot be empty";

    public const string ExecutorMustBeAtRespondedCollection = "Executor must be at responded collection";

    public const string ProjectTaskNotFound = "Task not found";
    public const string UserNotFound = "User not found";
    public const string ChatNotFound = "Chat not found";

    public const string UsersNotFound = "Users not found";
    public const string UsersAlreadyExists = "User already exists";

    public const string ChatAlreadyExists = "Chat already exists";

    public const string IncorrectLoginOrPassword = "Incorrect login or password";
    public const string UserAlreadyExists = "User with this name already exists.";

    public const string GlobalExceptionMessage = "Global exception handling exception: {Exception}";
    public const string UnexpectedError = "Unexpected error occured";
    public const string ServerError = "Server error";
    public const string NotFound = "Not found";
    public const string Validation = "Validation error";
    public const string Conflict = "Conflict";
    public const string Unauthorized = "Unauthorized";
    public const string Forbidden = "Forbidden";

    public const string AlreadyResponded = "You have already responded to this task";
    public const string OnlyCustomerCanCancel = "Only customer can cancel task.";
    public const string OnlyCustomerCanRate = "Only customer can rate executor.";
    public const string TaskMustBeDoneToRate = "Task must be done to rate executor.";
    public const string InvalidRatingValue = "Rating must be between {0} and {1}.";
    public const string CannotCancelDoneOrCancelled = "Cannot cancel done or cancelled task.";
    public const string ExecutorHasNoRating = "Executor has no rating yet.";
    public const string UserIsBlocked = "User is blocked.";

    public const string TaskIdCannotBeEmpty = "Task id cannot be empty.";
    public const string UploadedByUserIdCannotBeEmpty = "Uploader user id cannot be empty.";
    public const string OriginalFileNameCannotBeEmpty = "Original file name cannot be empty.";
    public const string StoredFileNameCannotBeEmpty = "Stored file name cannot be empty.";
    public const string FileSizeMustBePositive = "File size must be positive.";
    public const string FileSizeExceedsLimit = "File size exceeds the allowed limit of {0} MB.";
    public const string FileExtensionForbidden = "File extension {0} is forbidden.";
    public const string InvalidFilePath = "Invalid file path";
    public const string CannotAttachToClosedTask = "Cannot attach files to a closed task.";
    public const string OnlyParticipantsCanAttach = "Only the customer or the executor can attach files to the task.";
    public const string OnlyUploaderCanDeleteAttachment = "Only the uploader can delete the attachment.";
    public const string TaskAttachmentNotFound = "Attachment not found.";
}
````

---

## FILE: `Domain/Constants/LoggerMessages.cs`

````csharp
﻿namespace Domain.Constants;

public static class LoggerMessages
{
    public const string ProjectTaskOverdue = "Overdue TaskId: {Id}, Title: {Title}, ExecutorId: {ExecutorId}";
    public const string OverdueDeadlineWorkerException = "Exception while checking deadlines {Exception}";
}
````

---

## FILE: `Domain/Constants/RatingConstants.cs`

````csharp
﻿namespace Domain.Constants;

public static class RatingConstants
{
    public const int MinRating = 1;
    public const int MaxRating = 5;
    public const decimal NoRating = 0m;
    public const int ZeroCount = 0;
}
````

---

## FILE: `Domain/Domain.csproj`

````text
﻿<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <ProjectReference Include="..\Shared\Shared.csproj" />
  </ItemGroup>

</Project>
````

---

## FILE: `Domain/Entities/Chat.cs`

````csharp
﻿using Domain.Constants;
using Shared.Dtos.Responses;

namespace Domain.Entities;

public class Chat : Entity
{
    public Guid ProjectTaskId { get; private set; }

    private readonly List<Message> _messages = new();
    public IReadOnlyCollection<Message> Messages
        => _messages.AsReadOnly();

    private Chat() { }

    public static Result<Chat> Create(Guid projectTaskId)
    {
        var chat = new Chat()
        {
            Id = Guid.NewGuid(),
            ProjectTaskId = projectTaskId,
        };

        return Result<Chat>.Success(chat);
    }

    public Result AddMessage(
        string text,
        Guid senderId)
    {
        if (string.IsNullOrEmpty(text))
        {
            return Result.Failure(ErrorMessages.MessageTextCannotBeEmpty);
        }

        var message = new Message(
            text,
            senderId,
            Id,
            DateTimeOffset.UtcNow);

        _messages.Add(message);

        return Result.Success();
    }
}
````

---

## FILE: `Domain/Entities/Entity.cs`

````csharp
﻿using Domain.Constants;
using Shared.Dtos.Responses;

namespace Domain.Entities;

public abstract class Entity
{
    public Guid Id { get; protected set; }
    public bool IsDeleted { get; protected set; }

    public Result Delete()
    {
        if (IsDeleted)
        {
            return Result.Failure(ErrorMessages.EntityHasAlreadyDeleted);
        }

        IsDeleted = true;

        return Result.Success();
    }
}
````

---

## FILE: `Domain/Entities/Message.cs`

````csharp
﻿namespace Domain.Entities;

public class Message : Entity
{
    public string Text { get; private set; } = string.Empty;
    public Guid UserId { get; private set; }
    public Guid ChatId { get; private set; }
    public DateTimeOffset SentAt { get; private set; }

    private Message() { }

    internal Message(
        string text,
        Guid userId,
        Guid chatId,
        DateTimeOffset sentAt)
    {
        Id = Guid.NewGuid();
        Text = text;
        UserId = userId;
        ChatId = chatId;
        SentAt = sentAt;
    }
}
````

---

## FILE: `Domain/Entities/ProjectTask.cs`

````csharp
﻿using Domain.Constants;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Domain.Entities;

public class ProjectTask : Entity
{
    public string Title { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public decimal Price { get; private set; } = decimal.Zero;
    public ProjectTaskStatus Status { get; private set; }
    public DateTimeOffset StartsAt { get; private set; }
    public DateTimeOffset EndsAt { get; private set; }

    public Guid CustomerId { get; private set; }
    public Guid? ExecutorId { get; private set; }
    public decimal? ProjectRating { get; private set; }

    public ICollection<TaskResponse> Responses { get; private set; } = new List<TaskResponse>();
    public ICollection<TaskAttachment> Attachments { get; private set; } = new List<TaskAttachment>();

    private ProjectTask() { }

    public static Result<ProjectTask> Create(
        string title,
        string description,
        decimal price,
        DateTimeOffset startsAt,
        DateTimeOffset endsAt,
        Guid customerId)
    {
        var result = Validate(
            title,
            description,
            price,
            startsAt,
            endsAt,
            customerId);
        if (!result.IsSuccess)
        {
            return Result<ProjectTask>.Failure(result.Message);
        }

        var projectTask = new ProjectTask()
        {
            Id = Guid.NewGuid(),
            Title = title,
            Description = description,
            Price = price,
            StartsAt = startsAt,
            EndsAt = endsAt,
            CustomerId = customerId,
            Status = ProjectTaskStatus.Published
        };

        return Result<ProjectTask>.Success(projectTask);
    }

    public Result Update(
        string title,
        string description,
        decimal price,
        DateTimeOffset startsAt,
        DateTimeOffset endsAt,
        Guid customerId)
    {
        if (Status == ProjectTaskStatus.InProgress
            || Status == ProjectTaskStatus.Done
            || Status == ProjectTaskStatus.Cancelled)
        {
            return Result.Failure(ErrorMessages.CannotEditInThisStatus);
        }

        if (customerId != CustomerId)
        {
            return Result.Failure(ErrorMessages.CustomerMustBeSame);
        }

        var result = Validate(
            title,
            description,
            price,
            startsAt,
            endsAt,
            customerId);
        if (!result.IsSuccess)
        {
            return Result.Failure(result.Message);
        }

        Title = title;
        Description = description;
        Price = price;
        StartsAt = startsAt;
        EndsAt = endsAt;

        return Result.Success();
    }

    public Result Cancel(Guid currentUserId)
    {
        if (CustomerId != currentUserId)
        {
            return Result.Failure(ErrorMessages.OnlyCustomerCanCancel);
        }

        if (Status == ProjectTaskStatus.Done || Status == ProjectTaskStatus.Cancelled)
        {
            return Result.Failure(ErrorMessages.CannotCancelDoneOrCancelled);
        }

        Status = ProjectTaskStatus.Cancelled;

        return Result.Success();
    }

    public Result MarkAsDone(Guid currentUserId, decimal? rating)
    {
        if (CustomerId != currentUserId)
        {
            return Result.Failure(ErrorMessages.OnlyCustomerCanRate);
        }

        if (Status != ProjectTaskStatus.InProgress)
        {
            return Result.Failure(ErrorMessages.ProjectMustBeInProgress);
        }

        if (rating.HasValue &&
            (rating.Value < RatingConstants.MinRating || rating.Value > RatingConstants.MaxRating))
        {
            return Result.Failure(string.Format(
                ErrorMessages.InvalidRatingValue,
                RatingConstants.MinRating,
                RatingConstants.MaxRating));
        }

        Status = ProjectTaskStatus.Done;
        ProjectRating = rating;

        return Result.Success();
    }

    public Result RespondToTask(Guid executorId)
    {
        if (Status != ProjectTaskStatus.Published)
        {
            return Result.Failure(ErrorMessages.MustBePublishedToRespond);
        }

        if (CustomerId == executorId)
        {
            return Result.Failure(ErrorMessages.CustomerCannotRespond);
        }

        if (Responses.Any(r => r.ExecutorId == executorId))
        {
            return Result.Failure(ErrorMessages.AlreadyResponded);
        }

        var response = TaskResponse.Create(
            Id,
            executorId);

        Responses.Add(response);

        return Result.Success();
    }

    public Result AssignExecutor(Guid executorId, Guid currentUserId)
    {
        if (CustomerId != currentUserId)
        {
            return Result.Failure(ErrorMessages.OnlyCustomerCanAssign);
        }

        if (Status != ProjectTaskStatus.Published)
        {
            return Result.Failure(ErrorMessages.OnlyPublishedTaskCanBeAssigned);
        }

        if (!Responses.Any(r => r.ExecutorId == executorId))
        {
            return Result.Failure(ErrorMessages.ExecutorMustBeAtRespondedCollection);
        }

        Status = ProjectTaskStatus.InProgress;

        ExecutorId = executorId;

        return Result.Success();
    }

    private static Result Validate(
        string title,
        string description,
        decimal price,
        DateTimeOffset startsAt,
        DateTimeOffset endsAt,
        Guid customerId)
    {
        if (string.IsNullOrEmpty(title))
        {
            return Result.Failure(ErrorMessages.TitleCannotBeEmpty);
        }

        if (string.IsNullOrEmpty(description))
        {
            return Result.Failure(ErrorMessages.DescriptionCannotBeEmpty);
        }

        if (price < CurrencyConstants.BasePrice)
        {
            return Result.Failure(ErrorMessages.PriceConnotBeNegative);
        }

        if (startsAt < DateTimeOffset.UtcNow || endsAt < DateTimeOffset.UtcNow)
        {
            return Result.Failure(ErrorMessages.FutureDateTime);
        }

        if (endsAt <= startsAt)
        {
            return Result.Failure(ErrorMessages.EndDateMustBeAfterStartDate);
        }

        return Result.Success();
    }
}
````

---

## FILE: `Domain/Entities/TaskAttachment.cs`

````csharp
﻿using Domain.Constants;
using Shared.Dtos.Responses;

namespace Domain.Entities;

public class TaskAttachment : Entity
{
    public Guid TaskId { get; private set; }
    public ProjectTask Task { get; private set; } = null!;

    public Guid UploadedByUserId { get; private set; }
    public User UploadedByUser { get; private set; } = null!;

    public string OriginalFileName { get; private set; } = string.Empty;
    public string StoredFileName { get; private set; } = string.Empty;
    public string ContentType { get; private set; } = string.Empty;
    public long SizeBytes { get; private set; }
    public DateTimeOffset UploadedAt { get; private set; }

    private TaskAttachment() { }

    public static Result<TaskAttachment> Create(
        Guid taskId,
        Guid uploadedByUserId,
        string originalFileName,
        string storedFileName,
        string contentType,
        long sizeBytes)
    {
        var result = Validate(
            taskId,
            uploadedByUserId,
            originalFileName,
            storedFileName,
            sizeBytes);
        if (!result.IsSuccess)
        {
            return Result<TaskAttachment>.Failure(result.Message);
        }

        var attachment = new TaskAttachment()
        {
            Id = Guid.NewGuid(),
            TaskId = taskId,
            UploadedByUserId = uploadedByUserId,
            OriginalFileName = originalFileName,
            StoredFileName = storedFileName,
            ContentType = string.IsNullOrWhiteSpace(contentType)
                ? AttachmentConstants.DefaultContentType
                : contentType,
            SizeBytes = sizeBytes,
            UploadedAt = DateTimeOffset.UtcNow
        };

        return Result<TaskAttachment>.Success(attachment);
    }

    private static Result Validate(
        Guid taskId,
        Guid uploadedByUserId,
        string originalFileName,
        string storedFileName,
        long sizeBytes)
    {
        if (taskId == Guid.Empty)
        {
            return Result.Failure(ErrorMessages.TaskIdCannotBeEmpty);
        }

        if (uploadedByUserId == Guid.Empty)
        {
            return Result.Failure(ErrorMessages.UploadedByUserIdCannotBeEmpty);
        }

        if (string.IsNullOrWhiteSpace(originalFileName))
        {
            return Result.Failure(ErrorMessages.OriginalFileNameCannotBeEmpty);
        }

        if (string.IsNullOrWhiteSpace(storedFileName))
        {
            return Result.Failure(ErrorMessages.StoredFileNameCannotBeEmpty);
        }

        if (sizeBytes <= AttachmentConstants.MinSizeBytes)
        {
            return Result.Failure(ErrorMessages.FileSizeMustBePositive);
        }

        if (sizeBytes > AttachmentConstants.MaxSizeBytes)
        {
            return Result.Failure(string.Format(
                ErrorMessages.FileSizeExceedsLimit,
                AttachmentConstants.MaxSizeBytes / (1024 * 1024)));
        }

        return Result.Success();
    }
}
````

---

## FILE: `Domain/Entities/TaskResponse.cs`

````csharp
﻿namespace Domain.Entities;

public class TaskResponse : Entity
{
    public Guid TaskId { get; private set; }
    public Guid ExecutorId { get; private set; }
    public DateTimeOffset RespondedAt { get; private set; }
    public ProjectTask Task { get; private set; } = null!;

    private TaskResponse() { }

    public static TaskResponse Create(
        Guid taskId,
        Guid executorId)
    {
        return new TaskResponse
        {
            Id = Guid.NewGuid(),
            TaskId = taskId,
            ExecutorId = executorId,
            RespondedAt = DateTimeOffset.UtcNow
        };
    }
}
````

---

## FILE: `Domain/Entities/User.cs`

````csharp
﻿using Domain.Constants;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Domain.Entities;

public class User : Entity
{
    public string Name { get; private set; } = string.Empty;
    public UserRole Role { get; private set; }
    public string PasswordHash { get; private set; } = string.Empty;
    public decimal? Rating { get; private set; }
    public bool IsBlocked { get; private set; }

    private User() { }

    public static Result<User> Create(
        string name,
        string passwordhash,
        UserRole role)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result<User>.Failure(ErrorMessages.UserNameCannotBeEmpty);
        }

        if (string.IsNullOrEmpty(passwordhash))
        {
            return Result<User>.Failure(ErrorMessages.PasswordHashCannotBeEmpty);
        }

        if (role == UserRole.Admin)
        {
            return Result<User>.Failure(ErrorMessages.AdminRoleCannotSetup);
        }

        var user = new User()
        {
            Id = Guid.NewGuid(),
            Name = name,
            PasswordHash = passwordhash,
            Role = role,
        };

        return Result<User>.Success(user);
    }

    public Result Update(
        string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result.Failure(ErrorMessages.UserNameCannotBeEmpty);
        }

        Name = name;

        return Result.Success();
    }

    public void RecalculateRating(
        IReadOnlyCollection<decimal> projectRatings)
    {
        if (projectRatings.Count == RatingConstants.ZeroCount)
        {
            Rating = RatingConstants.NoRating;
            return;
        }

        Rating = projectRatings.Average();
    }

    public void Block()
    {
        IsBlocked = true;
    }

    public void Unblock()
    {
        IsBlocked = false;
    }

    public Result ChangeRole(UserRole role)
    {
        if (role == UserRole.Admin)
        {
            return Result.Failure(ErrorMessages.AdminRoleCannotSetup);
        }

        Role = role;

        return Result.Success();
    }
}
````

---

## FILE: `Domain/Entities/UserAction.cs`

````csharp
﻿using Shared.Enums;

namespace Domain.Entities;

public class UserAction : Entity
{
    public Guid UserId { get; private set; }
    public UserActionType ActionType { get; private set; }
    public string EntityType { get; private set; } = string.Empty;
    public Guid? EntityId { get; private set; }
    public DateTimeOffset PerformedAt { get; private set; }

    private UserAction() { }

    public static UserAction Create(
        Guid userId,
        UserActionType actionType,
        string entityType,
        Guid? entityId = null)
    {
        return new UserAction
        {
            Id = Guid.NewGuid(),
            UserId = userId,
            ActionType = actionType,
            EntityType = entityType,
            EntityId = entityId,
            PerformedAt = DateTimeOffset.UtcNow
        };
    }
}
````

---

## FILE: `Domain/Interfaces/Chats/IChatCommandRepository.cs`

````csharp
﻿using Domain.Entities;

namespace Domain.Interfaces.Chats;

public interface IChatCommandRepository
{
    Task AddAsync(Chat chat, CancellationToken cancellationToken = default);
    Task UpdateAsync(Chat chat, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid chatId, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/Chats/IChatQueryRepository.cs`

````csharp
﻿using Domain.Entities;

namespace Domain.Interfaces.Chats;

public interface IChatQueryRepository
{
    Task<Chat?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Chat?> GetByIdWithMessagesAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Chat?> GetByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);
    Task<Chat?> GetTrackedByIdAsync(Guid id, CancellationToken ct = default);
    Task<Dictionary<Guid, string>> GetUserNamesAsync(IEnumerable<Guid> userIds, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/Files/ITaskAttachmentCommandRepository.cs`

````csharp
﻿using Domain.Entities;

namespace Domain.Interfaces.Files;

public interface ITaskAttachmentCommandRepository
{
    Task AddAsync(TaskAttachment attachment, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/Files/ITaskAttachmentQueryRepository.cs`

````csharp
﻿using Domain.Entities;

namespace Domain.Interfaces.Files;

public interface ITaskAttachmentQueryRepository
{
    Task<TaskAttachment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<TaskAttachment?> GetTrackedByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<TaskAttachment>> GetByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/IUnitOfWork.cs`

````csharp
﻿namespace Domain.Interfaces;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/ProjectTasks/IProjectTaskCommandRepository.cs`

````csharp
﻿using Domain.Entities;

namespace Domain.Interfaces.ProjectTasks;

public interface IProjectTaskCommandRepository
{
    Task AddAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
    Task UpdateAsync(ProjectTask projectTask, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid projectTaskId, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/ProjectTasks/IProjectTaskQueryRepository.cs`

````csharp
﻿using Domain.Entities;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;

namespace Domain.Interfaces.ProjectTasks;

public interface IProjectTaskQueryRepository
{
    Task<ProjectTask?> GetByIdAsync(Guid projectTaskId, CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<ProjectTask>> GetOverdueAsync(CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask>> GetByCustomerIdAsync(Guid CustomerId, int page, int pageSize, CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask>> GetPublishedAsync(int page, int pageSize, CancellationToken cancellationToken = default);
    Task<List<TaskResponseDto>> GetResponsesByTaskIdAsync(Guid taskId, CancellationToken cancellationToken = default);
    Task<ProjectTask?> GetTrackedByIdAsync(Guid projectTaskId, CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask>> GetByExecutorIdAsync(Guid executorId, int page, int pageSize, CancellationToken cancellationToken = default);
    Task<IReadOnlyCollection<decimal>> GetRatingsByExecutorAsync(Guid executorId, CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask>> SearchPublishedAsync(string query, int page, int pageSize, CancellationToken cancellationToken = default);
    Task<PagedResult<ProjectTask>> SearchByCustomerIdAsync(Guid customerId, string query, int page, int pageSize, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/UserActions/IUserActionCommandRepository.cs`

````csharp
﻿using Domain.Entities;

namespace Domain.Interfaces.UserActions;

public interface IUserActionCommandRepository
{
    Task AddAsync(UserAction action, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/UserActions/IUserActionQueryRepository.cs`

````csharp
﻿using Domain.Entities;
using Shared.Dtos.Responses;

namespace Domain.Interfaces.UserActions;

public interface IUserActionQueryRepository
{
    Task<PagedResult<UserAction>> GetAsync(
        Guid? userId,
        int? actionType,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/Users/IUserCommandRepository.cs`

````csharp
﻿using Domain.Entities;

namespace Domain.Interfaces.Users;

public interface IUserCommandRepository
{
    Task AddAsync(User user, CancellationToken cancellationToken = default);
    Task UpdateAsync(User user, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid userId, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Domain/Interfaces/Users/IUserQueryRepository.cs`

````csharp
﻿using Domain.Entities;
using Shared.Dtos.Responses;

namespace Domain.Interfaces.Users;

public interface IUserQueryRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<User?> GetByNameAsync(string name, CancellationToken cancellationToken = default);
    Task<PagedResult<User>> GetAllAsync(int page, int pageSize, CancellationToken cancellationToken = default);
    Task<PagedResult<User>> SearchByNameAsync(string searchQuery, int page, int pageSize, CancellationToken cancellationToken = default);
    Task<User?> GetTrackedByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Dictionary<Guid, string>> GetNamesByIdsAsync(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken = default);
    Task<PagedResult<User>> GetPagedAsync(int page, int pageSize, CancellationToken cancellationToken = default);
}
````

---

## FILE: `Infrastructure/AppDbContext.cs`

````csharp
﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<ProjectTask> ProjectTasks { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public DbSet<TaskResponse> TaskResponses { get; set; }
    public DbSet<UserAction> UserActions { get; set; }
    public DbSet<TaskAttachment> TaskAttachments { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<Message>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<ProjectTask>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<TaskResponse>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<Chat>()
            .HasQueryFilter(u => !u.IsDeleted);

        modelBuilder.Entity<UserAction>()
            .HasQueryFilter(a => !a.IsDeleted);

        modelBuilder.Entity<TaskAttachment>()
            .HasQueryFilter(a => !a.IsDeleted);

        modelBuilder.Entity<ProjectTask>()
            .HasMany(p => p.Responses)
            .WithOne(r => r.Task)
            .HasForeignKey(r => r.TaskId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<TaskAttachment>()
            .HasOne(a => a.Task)
            .WithMany(t => t.Attachments)
            .HasForeignKey(a => a.TaskId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Chat>()
            .HasIndex(c => c.ProjectTaskId)
            .IsUnique();

        modelBuilder.Entity<ProjectTask>()
            .Property(r => r.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<Message>()
            .Property(m => m.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<TaskResponse>()
            .Property(r => r.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<Chat>()
            .Property(c => c.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<UserAction>()
            .Property(a => a.Id)
            .ValueGeneratedNever();

        modelBuilder.Entity<TaskAttachment>()
           .Property(a => a.Id)
           .ValueGeneratedNever();

        modelBuilder.Entity<ProjectTask>()
            .Property(t => t.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<ProjectTask>()
            .Property(t => t.ProjectRating)
            .HasPrecision(3, 1);

        modelBuilder.Entity<User>()
            .Property(u => u.Rating)
            .HasPrecision(3, 1);
    }
}
````

---

## FILE: `Infrastructure/Infrastructure.csproj`

````text
﻿<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="10.0.13" />
    <PackageReference Include="Microsoft.Extensions.Hosting" Version="10.0.13" />
    <PackageReference Include="Microsoft.Extensions.Options" Version="10.0.13" />
	<PackageReference Include="System.Security.Cryptography.Pkcs" Version="10.0.13" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Domain\Domain.csproj" />
  </ItemGroup>

</Project>
````

---

## FILE: `Infrastructure/Migrations/20260927160150_InitialCreate.cs`

````csharp
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectTaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StartsAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    EndsAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExecutorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectRating = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_ChatId",
                        column: x => x.ChatId,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatId",
                table: "Messages",
                column: "ChatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "ProjectTasks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Chats");
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20260927160150_InitialCreate.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20260927160150_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20260930073322_AddPasswordHash.cs`

````csharp
﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPasswordHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20260930073322_AddPasswordHash.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20260930073322_AddPasswordHash")]
    partial class AddPasswordHash
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261001100840_AddSentAtToMessage.cs`

````csharp
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSentAtToMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SentAt",
                table: "Messages",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SentAt",
                table: "Messages");
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261001100840_AddSentAtToMessage.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261001100840_AddSentAtToMessage")]
    partial class AddSentAtToMessage
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261001201155_AddedResponseTaskEntity.cs`

````csharp
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedResponseTaskEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskResponse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExecutorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RespondedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProjectTaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskResponse_ProjectTasks_ProjectTaskId",
                        column: x => x.ProjectTaskId,
                        principalTable: "ProjectTasks",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskResponse_ProjectTaskId",
                table: "TaskResponse",
                column: "ProjectTaskId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskResponse");
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261001201155_AddedResponseTaskEntity.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261001201155_AddedResponseTaskEntity")]
    partial class AddedResponseTaskEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("RespondedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectTaskId");

                    b.ToTable("TaskResponse");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", null)
                        .WithMany("Responses")
                        .HasForeignKey("ProjectTaskId");
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261001210320_FixRelationsBetweenReponseAndTask.cs`

````csharp
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRelationsBetweenReponseAndTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskResponse_ProjectTasks_ProjectTaskId",
                table: "TaskResponse");

            migrationBuilder.DropIndex(
                name: "IX_TaskResponse_ProjectTaskId",
                table: "TaskResponse");

            migrationBuilder.DropColumn(
                name: "ProjectTaskId",
                table: "TaskResponse");

            migrationBuilder.CreateIndex(
                name: "IX_TaskResponse_TaskId",
                table: "TaskResponse",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResponse_ProjectTasks_TaskId",
                table: "TaskResponse",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskResponse_ProjectTasks_TaskId",
                table: "TaskResponse");

            migrationBuilder.DropIndex(
                name: "IX_TaskResponse_TaskId",
                table: "TaskResponse");

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectTaskId",
                table: "TaskResponse",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskResponse_ProjectTaskId",
                table: "TaskResponse",
                column: "ProjectTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResponse_ProjectTasks_ProjectTaskId",
                table: "TaskResponse",
                column: "ProjectTaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id");
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261001210320_FixRelationsBetweenReponseAndTask.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261001210320_FixRelationsBetweenReponseAndTask")]
    partial class FixRelationsBetweenReponseAndTask
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("RespondedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskResponse");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Responses")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261001215958_FixRelations.cs`

````csharp
﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskResponse_ProjectTasks_TaskId",
                table: "TaskResponse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskResponse",
                table: "TaskResponse");

            migrationBuilder.RenameTable(
                name: "TaskResponse",
                newName: "TaskResponses");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResponse_TaskId",
                table: "TaskResponses",
                newName: "IX_TaskResponses_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskResponses",
                table: "TaskResponses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResponses_ProjectTasks_TaskId",
                table: "TaskResponses",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskResponses_ProjectTasks_TaskId",
                table: "TaskResponses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskResponses",
                table: "TaskResponses");

            migrationBuilder.RenameTable(
                name: "TaskResponses",
                newName: "TaskResponse");

            migrationBuilder.RenameIndex(
                name: "IX_TaskResponses_TaskId",
                table: "TaskResponse",
                newName: "IX_TaskResponse_TaskId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskResponse",
                table: "TaskResponse",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskResponse_ProjectTasks_TaskId",
                table: "TaskResponse",
                column: "TaskId",
                principalTable: "ProjectTasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261001215958_FixRelations.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261001215958_FixRelations")]
    partial class FixRelations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("RespondedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskResponses");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Responses")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261002165145_AddUserActions.cs`

````csharp
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    EntityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PerformedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserActions");
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261002165145_AddUserActions.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261002165145_AddUserActions")]
    partial class AddUserActions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("RespondedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskResponses");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.UserAction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<Guid?>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("PerformedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserActions");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Responses")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261002174150_AddUserBlocked.cs`

````csharp
﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserBlocked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Users",
                type: "decimal(3,1)",
                precision: 3,
                scale: 1,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectRating",
                table: "ProjectTasks",
                type: "decimal(3,1)",
                precision: 3,
                scale: 1,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Users");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Users",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldPrecision: 3,
                oldScale: 1,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ProjectRating",
                table: "ProjectTasks",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)",
                oldPrecision: 3,
                oldScale: 1,
                oldNullable: true);
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261002174150_AddUserBlocked.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261002174150_AddUserBlocked")]
    partial class AddUserBlocked
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("RespondedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskResponses");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.UserAction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<Guid?>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("PerformedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserActions");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Responses")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261006095229_AttacmentEntity.cs`

````csharp
﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AttacmentEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UploadedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OriginalFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoredFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeBytes = table.Column<long>(type: "bigint", nullable: false),
                    UploadedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAttachments_ProjectTasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "ProjectTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskAttachments_Users_UploadedByUserId",
                        column: x => x.UploadedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskAttachments_TaskId",
                table: "TaskAttachments",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAttachments_UploadedByUserId",
                table: "TaskAttachments",
                column: "UploadedByUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskAttachments");
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261006095229_AttacmentEntity.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261006095229_AttacmentEntity")]
    partial class AttacmentEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.TaskAttachment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("OriginalFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SizeBytes")
                        .HasColumnType("bigint");

                    b.Property<string>("StoredFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UploadedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UploadedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UploadedByUserId");

                    b.ToTable("TaskAttachments");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("RespondedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskResponses");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.UserAction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<Guid?>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("PerformedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserActions");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.TaskAttachment", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Attachments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "UploadedByUser")
                        .WithMany()
                        .HasForeignKey("UploadedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("UploadedByUser");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Responses")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261015152600_AddIndexToChat.cs`

````csharp
﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIndexToChat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Chats_ProjectTaskId",
                table: "Chats",
                column: "ProjectTaskId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chats_ProjectTaskId",
                table: "Chats");
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/20261015152600_AddIndexToChat.Designer.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20261015152600_AddIndexToChat")]
    partial class AddIndexToChat
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectTaskId")
                        .IsUnique();

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.TaskAttachment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("OriginalFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SizeBytes")
                        .HasColumnType("bigint");

                    b.Property<string>("StoredFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UploadedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UploadedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UploadedByUserId");

                    b.ToTable("TaskAttachments");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("RespondedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskResponses");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.UserAction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<Guid?>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("PerformedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserActions");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.TaskAttachment", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Attachments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "UploadedByUser")
                        .WithMany()
                        .HasForeignKey("UploadedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("UploadedByUser");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Responses")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Migrations/AppDbContextModelSnapshot.cs`

````csharp
﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "10.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("ProjectTaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectTaskId")
                        .IsUnique();

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("SentAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("EndsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ProjectRating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<DateTimeOffset>("StartsAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("Domain.Entities.TaskAttachment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("OriginalFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SizeBytes")
                        .HasColumnType("bigint");

                    b.Property<string>("StoredFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("UploadedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UploadedByUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.HasIndex("UploadedByUserId");

                    b.ToTable("TaskAttachments");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExecutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("RespondedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskResponses");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Rating")
                        .HasPrecision(3, 1)
                        .HasColumnType("decimal(3,1)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.UserAction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActionType")
                        .HasColumnType("int");

                    b.Property<Guid?>("EntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EntityType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("PerformedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("UserActions");
                });

            modelBuilder.Entity("Domain.Entities.Message", b =>
                {
                    b.HasOne("Domain.Entities.Chat", null)
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.TaskAttachment", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Attachments")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "UploadedByUser")
                        .WithMany()
                        .HasForeignKey("UploadedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("UploadedByUser");
                });

            modelBuilder.Entity("Domain.Entities.TaskResponse", b =>
                {
                    b.HasOne("Domain.Entities.ProjectTask", "Task")
                        .WithMany("Responses")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Domain.Entities.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.Entities.ProjectTask", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("Responses");
                });
#pragma warning restore 612, 618
        }
    }
}
````

---

## FILE: `Infrastructure/Repositories/Chats/ChatCommandRepository.cs`

````csharp
﻿using Domain.Entities;
using Domain.Interfaces.Chats;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Chats;

public class ChatCommandRepository : IChatCommandRepository
{
    private readonly AppDbContext _context;

    public ChatCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        Chat chat,
        CancellationToken cancellationToken = default)
    {
        await _context.Chats.AddAsync(chat, cancellationToken);
    }

    public async Task UpdateAsync(
        Chat chat,
        CancellationToken cancellationToken = default)
    {
        _context.Chats.Update(chat);
    }

    public async Task DeleteAsync(
        Guid chatId,
        CancellationToken cancellationToken = default)
    {
        var deletedChat = await _context.Chats
            .FirstOrDefaultAsync(p => p.Id == chatId, cancellationToken);

        if (deletedChat is not null)
        {
            deletedChat.Delete();
        }
    }
}
````

---

## FILE: `Infrastructure/Repositories/Chats/ChatQueryRepository.cs`

````csharp
﻿using Domain.Entities;
using Domain.Interfaces.Chats;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Chats;

public class ChatQueryRepository : IChatQueryRepository
{
    private readonly AppDbContext _context;

    public ChatQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Chat?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.Chats
            .AsNoTracking()
            .Include(c => c.Messages.OrderBy(m => m.SentAt))
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task<Dictionary<Guid, string>> GetUserNamesAsync(
        IEnumerable<Guid> userIds,
        CancellationToken cancellationToken = default)
    {
        var ids = userIds.Distinct().ToList();

        return await _context.Users
            .AsNoTracking()
            .Where(u => ids.Contains(u.Id))
            .ToDictionaryAsync(u => u.Id, u => u.Name, cancellationToken);
    }

    public async Task<Chat?> GetByIdWithMessagesAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.Chats
            .AsNoTracking()
            .Include(c => c.Messages.OrderBy(m => m.SentAt))
            .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task<Chat?> GetByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        return await _context.Chats
            .AsNoTracking()
            .Include(c => c.Messages.OrderBy(m => m.SentAt))
            .FirstOrDefaultAsync(c => c.ProjectTaskId == taskId, cancellationToken);
    }

    public async Task<Chat?> GetTrackedByIdAsync(
        Guid id,
        CancellationToken ct = default)
    {
        return await _context.Chats
            .Include(c => c.Messages)
            .FirstOrDefaultAsync(c => c.Id == id, ct);
    }
}
````

---

## FILE: `Infrastructure/Repositories/Files/TaskAttachmentCommandRepository.cs`

````csharp
﻿using Domain.Entities;
using Domain.Interfaces.Files;

namespace Infrastructure.Repositories.Files;

public class TaskAttachmentCommandRepository : ITaskAttachmentCommandRepository
{
    private readonly AppDbContext _context;

    public TaskAttachmentCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        TaskAttachment attachment,
        CancellationToken cancellationToken = default)
    {
        await _context.TaskAttachments.AddAsync(attachment, cancellationToken);
    }
}
````

---

## FILE: `Infrastructure/Repositories/Files/TaskAttachmentQueryRepository.cs`

````csharp
﻿using Domain.Entities;
using Domain.Interfaces.Files;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Files;

public class TaskAttachmentQueryRepository : ITaskAttachmentQueryRepository
{
    private readonly AppDbContext _context;

    public TaskAttachmentQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<TaskAttachment?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.TaskAttachments
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
    }

    public async Task<TaskAttachment?> GetTrackedByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.TaskAttachments
            .FirstOrDefaultAsync(a => a.Id == id, cancellationToken);
    }

    public async Task<IReadOnlyCollection<TaskAttachment>> GetByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        return await _context.TaskAttachments
            .AsNoTracking()
            .Where(a => a.TaskId == taskId)
            .OrderByDescending(a => a.UploadedAt)
            .ToListAsync(cancellationToken);
    }
}
````

---

## FILE: `Infrastructure/Repositories/ProjectTasks/ProjectTaskCommandRepository.cs`

````csharp
﻿using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.ProjectTasks;

public class ProjectTaskCommandRepository : IProjectTaskCommandRepository
{
    private readonly AppDbContext _context;

    public ProjectTaskCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        ProjectTask projectTask,
        CancellationToken cancellationToken = default)
    {
        await _context.ProjectTasks.AddAsync(projectTask, cancellationToken);
    }

    public async Task UpdateAsync(
        ProjectTask projectTask,
        CancellationToken cancellationToken = default)
    {
        _context.ProjectTasks.Update(projectTask);
    }

    public async Task DeleteAsync(
        Guid projectTaskId,
        CancellationToken cancellationToken = default)
    {
        var deletedProjectTask = await _context.ProjectTasks
            .FirstOrDefaultAsync(p => p.Id == projectTaskId, cancellationToken);

        if (deletedProjectTask is not null)
        {
            deletedProjectTask.Delete();
        }
    }
}
````

---

## FILE: `Infrastructure/Repositories/ProjectTasks/ProjectTaskQueryRepository.cs`

````csharp
﻿using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.ProjectTasks;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;

namespace Infrastructure.Repositories.ProjectTasks;

public class ProjectTaskQueryRepository : IProjectTaskQueryRepository
{
    private readonly AppDbContext _context;

    public ProjectTaskQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ProjectTask?> GetByIdAsync(
        Guid projectTaskId,
        CancellationToken cancellationToken = default)
    {
        var projectTask = await _context.ProjectTasks
           .AsNoTracking()
           .FirstOrDefaultAsync(p => p.Id == projectTaskId, cancellationToken);

        return projectTask;
    }

    public async Task<PagedResult<ProjectTask>> GetPublishedAsync(
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.ProjectTasks
           .AsNoTracking()
           .Include(t => t.Responses)
           .Where(t => t.Status == ProjectTaskStatus.Published)
           .OrderByDescending(t => t.StartsAt);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }

    public async Task<PagedResult<ProjectTask>> GetByCustomerIdAsync(
        Guid CustomerId,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.ProjectTasks
           .AsNoTracking()
           .Where(t => t.CustomerId == CustomerId)
           .OrderByDescending(t => t.StartsAt);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }

    public async Task<IReadOnlyCollection<ProjectTask>> GetOverdueAsync(
        CancellationToken cancellationToken = default)
    {
        var items = await _context.ProjectTasks
            .AsNoTracking()
            .Where(t => t.EndsAt < DateTimeOffset.UtcNow && t.Status == ProjectTaskStatus.InProgress)
            .ToListAsync(cancellationToken);

        return items;
    }

    public async Task<List<TaskResponseDto>> GetResponsesByTaskIdAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        var task = await _context.ProjectTasks
            .Include(t => t.Responses)
            .FirstOrDefaultAsync(t => t.Id == taskId, cancellationToken);

        if (task is null || !task.Responses.Any())
        {
            return new List<TaskResponseDto>();
        }

        var executorIds = task.Responses
            .Select(r => r.ExecutorId)
            .Distinct()
            .ToList();

        var users = await _context.Users
            .Where(u => executorIds.Contains(u.Id))
            .ToDictionaryAsync(u => u.Id, u => new { u.Name, u.Rating }, cancellationToken);

        var responses = task.Responses
            .Where(r => users.ContainsKey(r.ExecutorId))
            .Select(r => new TaskResponseDto
            {
                ExecutorId = r.ExecutorId,
                ExecutorName = users[r.ExecutorId].Name,
                ExecutorRating = users[r.ExecutorId].Rating,
                RespondedAt = r.RespondedAt
            })
            .ToList();

        return responses;
    }

    public async Task<ProjectTask?> GetTrackedByIdAsync(
        Guid projectTaskId,
        CancellationToken cancellationToken = default)
    {
        return await _context.ProjectTasks
            .Include(p => p.Responses)
            .FirstOrDefaultAsync(p => p.Id == projectTaskId, cancellationToken);
    }

    public async Task<PagedResult<ProjectTask>> GetByExecutorIdAsync(
         Guid executorId,
         int page,
         int pageSize,
         CancellationToken cancellationToken = default)
    {
        var query = _context.ProjectTasks
            .AsNoTracking()
            .Where(t => t.ExecutorId == executorId)
            .OrderByDescending(t => t.StartsAt);

        var totalCount = await query.CountAsync(cancellationToken);
        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }

    public async Task<IReadOnlyCollection<decimal>> GetRatingsByExecutorAsync(
        Guid executorId,
        CancellationToken cancellationToken = default)
    {
        var ratings = await _context.ProjectTasks
            .AsNoTracking()
            .Where(t => t.ExecutorId == executorId
                     && t.ProjectRating != null
                     && t.Status == ProjectTaskStatus.Done)
            .Select(t => t.ProjectRating!.Value)
            .ToListAsync(cancellationToken);

        return ratings;
    }
    public async Task<PagedResult<ProjectTask>> SearchPublishedAsync(
        string query,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var search = _context.ProjectTasks
            .AsNoTracking()
            .Include(t => t.Responses)
            .Where(t => t.Status == ProjectTaskStatus.Published
                     && t.Title.Contains(query))
            .OrderByDescending(t => t.StartsAt);

        var totalCount = await search.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await search
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }

    public async Task<PagedResult<ProjectTask>> SearchByCustomerIdAsync(
        Guid customerId,
        string query,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var search = _context.ProjectTasks
            .AsNoTracking()
            .Where(t => t.CustomerId == customerId
                     && t.Title.Contains(query))
            .OrderByDescending(t => t.StartsAt);

        var totalCount = await search.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<ProjectTask>.Empty(page, pageSize);
        }

        var items = await search
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<ProjectTask>.Create(items, page, pageSize, totalCount);
    }
}
````

---

## FILE: `Infrastructure/Repositories/UnitOfWork.cs`

````csharp
﻿using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await _context.SaveChangesAsync(cancellationToken);
    }
}
````

---

## FILE: `Infrastructure/Repositories/UserActions/UserActionCommandRepository.cs`

````csharp
﻿using Domain.Entities;
using Domain.Interfaces.UserActions;

namespace Infrastructure.Repositories.UserActions;

public class UserActionCommandRepository : IUserActionCommandRepository
{
    private readonly AppDbContext _context;

    public UserActionCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        UserAction action,
        CancellationToken cancellationToken = default)
    {
        await _context.UserActions.AddAsync(action, cancellationToken);
    }
}
````

---

## FILE: `Infrastructure/Repositories/UserActions/UserActionQueryRepository.cs`

````csharp
﻿using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.UserActions;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos.Responses;

namespace Infrastructure.Repositories.UserActions;

public class UserActionQueryRepository : IUserActionQueryRepository
{
    private readonly AppDbContext _context;

    public UserActionQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<PagedResult<UserAction>> GetAsync(
        Guid? userId,
        int? actionType,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.UserActions
            .AsNoTracking()
            .OrderByDescending(a => a.PerformedAt)
            .AsQueryable();

        if (userId.HasValue)
        {
            query = query.Where(a => a.UserId == userId.Value);
        }

        if (actionType.HasValue)
        {
            query = query.Where(a => (int)a.ActionType == actionType.Value);
        }

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<UserAction>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<UserAction>.Create(items, page, pageSize, totalCount);
    }
}
````

---

## FILE: `Infrastructure/Repositories/Users/UserCommandRepository.cs`

````csharp
﻿using Domain.Entities;
using Domain.Interfaces.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Users;

public class UserCommandRepository : IUserCommandRepository
{
    private readonly AppDbContext _context;

    public UserCommandRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(
        User user,
        CancellationToken cancellationToken = default)
    {
        await _context.Users.AddAsync(user, cancellationToken);
    }

    public async Task UpdateAsync(
        User user,
        CancellationToken cancellationToken = default)
    {
        _context.Users.Update(user);
    }

    public async Task DeleteAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        var deletedUser = await _context.Users
            .FirstOrDefaultAsync(p => p.Id == userId, cancellationToken);

        if (deletedUser is not null)
        {
            deletedUser.Delete();
        }
    }
}
````

---

## FILE: `Infrastructure/Repositories/Users/UserQueryRepository.cs`

````csharp
﻿using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces.Users;
using Microsoft.EntityFrameworkCore;
using Shared.Dtos.Responses;

namespace Infrastructure.Repositories.Users;

public class UserQueryRepository : IUserQueryRepository
{
    private readonly AppDbContext _context;

    public UserQueryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByIdAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        return await _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == userId, cancellationToken);
    }

    public async Task<User?> GetByNameAsync(
        string name,
        CancellationToken cancellationToken = default)
    {
        var user = await _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Name == name, cancellationToken);

        return user;
    }

    public async Task<PagedResult<User>> GetAllAsync(
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.Users
            .AsNoTracking()
            .OrderBy(u => u.Name);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<User>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<User>.Create(items, page, pageSize, totalCount);
    }

    public async Task<PagedResult<User>> SearchByNameAsync(
        string searchQuery,
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.Users
            .AsNoTracking()
            .Where(u => u.Name.Contains(searchQuery))
            .OrderBy(u => u.Name);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<User>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<User>.Create(items, page, pageSize, totalCount);
    }

    public async Task<User?> GetTrackedByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<Dictionary<Guid, string>> GetNamesByIdsAsync(
        IReadOnlyCollection<Guid> ids,
        CancellationToken cancellationToken = default)
    {
        return await _context.Users
            .AsNoTracking()
            .Where(u => ids.Contains(u.Id))
            .ToDictionaryAsync(u => u.Id, u => u.Name, cancellationToken);
    }

    public async Task<PagedResult<User>> GetPagedAsync(
        int page,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        var query = _context.Users
            .AsNoTracking()
            .OrderBy(u => u.Name);

        var totalCount = await query.CountAsync(cancellationToken);

        if (totalCount == CurrencyConstants.ZeroElements)
        {
            return PagedResult<User>.Empty(page, pageSize);
        }

        var items = await query
            .Skip((page - CurrencyConstants.OffsetPage) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return PagedResult<User>.Create(items, page, pageSize, totalCount);
    }
}
````

---

## FILE: `README.md`

````markdown
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
````

---

## FILE: `Shared/Dtos/Requests/Chats/AddMessageChatDto.cs`

````csharp
﻿namespace Shared.Dtos.Requests.Chats;

public record class AddMessageChatDto(
    string Text);
````

---

## FILE: `Shared/Dtos/Requests/PageDto.cs`

````csharp
﻿namespace Shared.Dtos.Requests;

public record class PageDto(
    int Page,
    int PageSize);
````

---

## FILE: `Shared/Dtos/Requests/ProjectTasks/AssignProjectTaskDto.cs`

````csharp
﻿namespace Shared.Dtos.Requests.ProjectTasks;

public record class AssignProjectTaskDto(
    Guid ExecutorId);
````

---

## FILE: `Shared/Dtos/Requests/ProjectTasks/CreateProjectTaskDto.cs`

````csharp
﻿namespace Shared.Dtos.Requests.ProjectTasks;

public record class CreateProjectTaskDto
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public DateTimeOffset StartsAt { get; set; }
    public DateTimeOffset EndsAt { get; set; }
}
````

---

## FILE: `Shared/Dtos/Requests/ProjectTasks/UpdateProjectTaskDto.cs`

````csharp
﻿namespace Shared.Dtos.Requests.ProjectTasks;

public record class UpdateProjectTaskDto(
    string Title,
    string Description,
    decimal Price,
    DateTimeOffset StartsAt,
    DateTimeOffset EndsAt);
````

---

## FILE: `Shared/Dtos/Requests/Users/ChangeRoleUserDto.cs`

````csharp
﻿using Shared.Enums;

namespace Shared.Dtos.Requests.Users;

public record class ChangeRoleUserDto(
    UserRole NewRole);
````

---

## FILE: `Shared/Dtos/Requests/Users/LoginDto.cs`

````csharp
﻿namespace Shared.Dtos.Requests.Users;

public record LoginDto(
    string Name,
    string Password);
````

---

## FILE: `Shared/Dtos/Requests/Users/RegisterDto.cs`

````csharp
﻿using Shared.Enums;

namespace Shared.Dtos.Requests.Users;

public record RegisterUserDto(
    string Name,
    string Password,
    UserRole Role);
````

---

## FILE: `Shared/Dtos/Requests/Users/UpdateUserDto.cs`

````csharp
﻿namespace Shared.Dtos.Requests.Users;

public record class UpdateUserDto(
    string Name);
````

---

## FILE: `Shared/Dtos/Responses/Chats/ChatDto.cs`

````csharp
﻿namespace Shared.Dtos.Responses.Chats;

public class ChatDto
{
    public Guid Id { get; set; }
    public Guid ProjectTaskId { get; set; }
    public List<MessageDto> Messages { get; set; } = new();

    public ChatDto() { }

    public ChatDto(
        Guid id,
        Guid projectTaskId,
        List<MessageDto> messages)
    {
        Id = id;
        ProjectTaskId = projectTaskId;
        Messages = messages;
    }
}
````

---

## FILE: `Shared/Dtos/Responses/Chats/MessageDto.cs`

````csharp
﻿namespace Shared.Dtos.Responses.Chats;

public class MessageDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public DateTimeOffset SentAt { get; set; }

    public MessageDto() { }

    public MessageDto(
        Guid id,
        Guid userId,
        string userName,
        string text,
        DateTimeOffset sentAt)
    {
        Id = id;
        UserId = userId;
        Text = text;
        SentAt = sentAt;
        UserName = userName;
    }
}
````

---

## FILE: `Shared/Dtos/Responses/PagedResult.cs`

````csharp
﻿namespace Shared.Dtos.Responses;

public class PagedResult<T>
{
    private static int ZeroElements = 0;
    private static int MinPage = 0;

    public IReadOnlyCollection<T> Collection { get; set; } = null!;
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public int TotalPages { get; set; }

    public bool HasPreviousPage
        => Page > MinPage;

    public bool HasNextPage
        => Page < TotalPages;

    public PagedResult() { }

    private PagedResult(
        IReadOnlyCollection<T> items,
        int page,
        int pageSize,
        int totalCount)
    {
        Collection = items;
        Page = page;
        PageSize = pageSize;
        TotalCount = totalCount;
        TotalPages = (int)Math.Ceiling((double)TotalCount / PageSize);
    }

    public static PagedResult<T> Create(
        IReadOnlyList<T> items,
        int page,
        int pageSize,
        int totalCount)
    {
        return new PagedResult<T>(items, page, pageSize, totalCount);
    }

    public static PagedResult<T> Empty(
        int page,
        int pageSize)
    {
        return new PagedResult<T>(Array.Empty<T>(), page, pageSize, ZeroElements);
    }
}

````

---

## FILE: `Shared/Dtos/Responses/ProjectTasks/AttachmentFileResult.cs`

````csharp
﻿namespace Shared.Dtos.Responses.ProjectTasks;

public class AttachmentFileResult
{
    public string FileName { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public byte[] Content { get; set; } = Array.Empty<byte>();
}
````

---

## FILE: `Shared/Dtos/Responses/ProjectTasks/MarkAsDoneProjectTaskDto.cs`

````csharp
﻿namespace Shared.Dtos.Requests.ProjectTasks;

public record class MarkAsDoneProjectTaskDto(
    decimal? Rating);
````

---

## FILE: `Shared/Dtos/Responses/ProjectTasks/ProjectTaskDto.cs`

````csharp
﻿using Shared.Enums;

namespace Shared.Dtos.Responses.ProjectTasks;

public class ProjectTaskDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public ProjectTaskStatus Status { get; set; }
    public DateTimeOffset StartsAt { get; set; }
    public DateTimeOffset EndsAt { get; set; }
    public bool IsRespondedByCurrentUser { get; set; }
    public decimal? ProjectRating { get; set; }
    public string Currency { get; set; } = string.Empty;

    public Guid CustomerId { get; set; }
    public Guid? ExecutorId { get; set; }

    public ProjectTaskDto() { }

    public ProjectTaskDto(
        Guid id,
        string title,
        string description,
        decimal price,
        ProjectTaskStatus status,
        DateTimeOffset startsAt,
        DateTimeOffset endsAt,
        bool isRespondedByCurrentUser,
        decimal? projectRating,
        Guid customerId,
        Guid? executorId,
        string currency)
    {
        Id = id;
        Title = title;
        Description = description;
        Price = price;
        Status = status;
        StartsAt = startsAt;
        EndsAt = endsAt;
        IsRespondedByCurrentUser = isRespondedByCurrentUser;
        ProjectRating = projectRating;
        CustomerId = customerId;
        ExecutorId = executorId;
        Currency = currency;
    }
}
````

---

## FILE: `Shared/Dtos/Responses/ProjectTasks/TaskAttachmentDto.cs`

````csharp
﻿namespace Shared.Dtos.Responses.ProjectTasks;

public class TaskAttachmentDto
{
    public Guid Id { get; set; }
    public Guid TaskId { get; set; }
    public Guid UploadedByUserId { get; set; }
    public string OriginalFileName { get; set; } = string.Empty;
    public string ContentType { get; set; } = string.Empty;
    public long SizeBytes { get; set; }
    public DateTimeOffset UploadedAt { get; set; }

    public TaskAttachmentDto() { }

    public TaskAttachmentDto(
        Guid id,
        Guid taskId,
        Guid uploadedByUserId,
        string originalFileName,
        string contentType,
        long sizeBytes,
        DateTimeOffset uploadedAt)
    {
        Id = id;
        TaskId = taskId;
        UploadedByUserId = uploadedByUserId;
        OriginalFileName = originalFileName;
        ContentType = contentType;
        SizeBytes = sizeBytes;
        UploadedAt = uploadedAt;
    }
}
````

---

## FILE: `Shared/Dtos/Responses/ProjectTasks/TaskResponseDto.cs`

````csharp
﻿namespace Shared.Dtos.Responses.ProjectTasks;

public record class TaskResponseDto
{
    public Guid ExecutorId { get; set; }
    public string ExecutorName { get; set; } = string.Empty;
    public DateTimeOffset RespondedAt { get; set; }
    public decimal? ExecutorRating { get; set; }
}
````

---

## FILE: `Shared/Dtos/Responses/Result.cs`

````csharp
﻿using Shared.Enums;

namespace Shared.Dtos.Responses;

public interface IResult
{
    bool IsSuccess { get; }
}

public class Result : IResult
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; } = string.Empty;
    public ErrorType Error { get; private set; }

    public static Result Success()
    {
        return new Result
        {
            IsSuccess = true,
        };
    }

    public static Result Failure(
        string message,
        ErrorType error = ErrorType.Failure)
    {
        return new Result
        {
            IsSuccess = false,
            Message = message,
            Error = error
        };
    }
}

public class Result<T> : IResult
    where T : class
{
    public bool IsSuccess { get; private set; }
    public string Message { get; private set; } = string.Empty;
    public T? Value { get; private set; } = null;
    public ErrorType Error { get; private set; }

    public static Result<T> Success(T value)
    {
        return new Result<T>
        {
            IsSuccess = true,
            Value = value
        };
    }

    public static Result<T> Failure(
        string message,
        ErrorType error = ErrorType.Failure)
    {
        return new Result<T>
        {
            IsSuccess = false,
            Message = message,
            Error = error
        };
    }
}

````

---

## FILE: `Shared/Dtos/Responses/UserActions/UserActionDto.cs`

````csharp
﻿using Shared.Enums;

namespace Shared.Dtos.Responses.UserActions;

public record class UserActionDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public UserActionType ActionType { get; set; }
    public string EntityType { get; set; } = string.Empty;
    public DateTimeOffset PerformedAt { get; set; }
}
````

---

## FILE: `Shared/Dtos/Responses/Users/AuthDto.cs`

````csharp
﻿namespace Shared.Dtos.Responses.Users;

public record class AuthDto
{
    public string Id { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;

    public AuthDto() { }

    public AuthDto(
        string token,
        string name,
        string role,
        string id)
    {
        Token = token;
        Name = name;
        Role = role;
        Id = id;
    }
}
````

---

## FILE: `Shared/Dtos/Responses/Users/UserDto.cs`

````csharp
﻿using Shared.Enums;

namespace Shared.Dtos.Responses.Users;

public record class UserDto(
    Guid Id,
    string Name,
    UserRole Role,
    decimal? Rating,
    bool IsBlocked);
````

---

## FILE: `Shared/Enums/ErrorType.cs`

````csharp
﻿namespace Shared.Enums;

public enum ErrorType
{
    NotFound,
    Validation,
    Conflict,
    Unauthorized,
    Forbidden,
    Failure
}
````

---

## FILE: `Shared/Enums/ProjectTaskStatus.cs`

````csharp
﻿namespace Shared.Enums;

public enum ProjectTaskStatus
{
    Published,
    InProgress,
    Done,
    Cancelled,
}
````

---

## FILE: `Shared/Enums/UserAction.cs`

````csharp
﻿namespace Shared.Enums;

public enum UserActionType
{
    Registered,
    LoggedIn,
    CreatedTask,
    UpdatedTask,
    DeletedTask,
    CancelledTask,
    RespondedToTask,
    AssignedExecutor,
    MarkedTaskDone,
    SentMessage,
    CreatedChat,
    DeletedChat,
    UserBlocked,
    UserUnblocked,
    UserRoleChanged,
    UserDeleted
}
````

---

## FILE: `Shared/Enums/UserRole.cs`

````csharp
﻿namespace Shared.Enums;

public enum UserRole
{
    Customer,
    Executor,
    Admin
}
````

---

## FILE: `Shared/Shared.csproj`

````text
﻿<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
````

---

## FILE: `Task Marketplace.slnx`

````text
<Solution>
  <Folder Name="/Presentation/">
    <Project Path="Blazor Web App/Blazor Web App.csproj" Id="02384016-ea71-49c2-9fc6-644b00343494" />
    <Project Path="Web Api/Web Api.csproj" />
  </Folder>
  <Project Path="Application/Application.csproj" />
  <Project Path="Domain/Domain.csproj" />
  <Project Path="Infrastructure/Infrastructure.csproj" />
  <Project Path="Shared/Shared.csproj" Id="135bf695-b4f1-4f3b-a89c-9d44b2c8260e" />
</Solution>
````

---

## FILE: `TgBot/Program.cs`

````csharp
﻿Console.WriteLine("Hello, World!");
````

---

## FILE: `TgBot/TgBot.csproj`

````text
﻿<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
````

---

## FILE: `Web Api/appsettings.json`

````json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "AppConfig": {
    "AppName": "Task Marketplace"
  },
  "FileSettings": {
    "FileName": "Files"
  },
  "JwtSettings": {
    "ValidAudiences": [ "TaskMarketplace.Api" ],
    "ValidIssuers": [ "TaskMarketplace.Api" ]
  }
}
````

---

## FILE: `Web Api/Controllers/AuthController.cs`

````csharp
﻿using Application.Users.Commands.Login;
using Application.Users.Commands.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests.Users;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediatr;

    public AuthController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(
        [FromBody] RegisterUserDto request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterUserCommand(
            request.Name,
            request.Password,
            request.Role);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(
        [FromBody] LoginDto request,
        CancellationToken cancellationToken)
    {
        var command = new LoginUserCommand(
            request.Name,
            request.Password);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }
}
````

---

## FILE: `Web Api/Controllers/ChatController.cs`

````csharp
﻿using Application.Chats.Commands.AddMessage;
using Application.Chats.Commands.Create;
using Application.Chats.Commands.Delete;
using Application.Chats.Queries.GetById;
using Application.Chats.Queries.GetByTaskId;
using Application.Chats.Queries.GetWithMessages;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests.Chats;
using Shared.Enums;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ChatController : ControllerBase
{
    private readonly IMediator _mediatr;

    public ChatController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromQuery] Guid projectTaskId,
        CancellationToken cancellationToken)
    {
        var command = new CreateChatCommand(projectTaskId);

        var result = await _mediatr.Send(command, cancellationToken);

        if (!result.IsSuccess)
        {
            return result.ToResponse(this);
        }

        return CreatedAtAction(nameof(GetById), new { id = result.Value!.Id }, result.Value);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = $"{nameof(UserRole.Customer)},{nameof(UserRole.Admin)}")]
    public async Task<IActionResult> Delete(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new DeleteChatCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost("{id}/messages")]
    public async Task<IActionResult> AddMessage(
        Guid id,
        [FromBody] AddMessageChatDto request,
        CancellationToken cancellationToken)
    {
        var command = new AddMessageCommand(id, request.Text);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetChatByIdQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("task/{id}")]
    public async Task<IActionResult> GetByTaskId(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetChatByTaskIdQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("{id}/messages")]
    public async Task<IActionResult> GetAll(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetChatWithMessagesQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }
}
````

---

## FILE: `Web Api/Controllers/ProjectTaskController.cs`

````csharp
﻿using Application.Interfaces;
using Application.ProjectTasks.Commands.AssignExecutor;
using Application.ProjectTasks.Commands.Cancel;
using Application.ProjectTasks.Commands.Create;
using Application.ProjectTasks.Commands.Delete;
using Application.ProjectTasks.Commands.MarkAsDone;
using Application.ProjectTasks.Commands.RespondToTask;
using Application.ProjectTasks.Commands.Update;
using Application.ProjectTasks.Queries.GetAssigned;
using Application.ProjectTasks.Queries.GetProjectTaskById;
using Application.ProjectTasks.Queries.GetPublishedTasks;
using Application.ProjectTasks.Queries.GetResponses;
using Application.ProjectTasks.Queries.GetTasksByCustomer;
using Application.ProjectTasks.Queries.SearchTasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests;
using Shared.Dtos.Requests.ProjectTasks;
using Shared.Enums;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class ProjectTaskController : ControllerBase
{
    private readonly IMediator _mediatr;
    private readonly ICurrentUser _currentUser;

    public ProjectTaskController(IMediator mediatr, ICurrentUser currentUser)
    {
        _mediatr = mediatr;
        _currentUser = currentUser;
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        [FromBody] CreateProjectTaskDto request,
        CancellationToken cancellationToken)
    {
        var command = new CreateProjectTaskCommand(
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt);

        var result = await _mediatr.Send(command, cancellationToken);

        if (!result.IsSuccess)
        {
            return result.ToResponse(this);
        }

        return CreatedAtAction(nameof(GetById), new { id = result.Value!.Id }, result.Value);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new DeleteProjectTaskCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(
        Guid id,
        [FromBody] UpdateProjectTaskDto request,
        CancellationToken cancellationToken)
    {
        var command = new UpdateProjectTaskCommand(
            id,
            request.Title,
            request.Description,
            request.Price,
            request.StartsAt,
            request.EndsAt);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Executor))]
    [HttpPost("{id}/respond")]
    public async Task<IActionResult> Respond(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new RespondToTaskCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPost("{id}/mark-as-done")]
    public async Task<IActionResult> MarkAsDone(
        Guid id,
        [FromBody] MarkAsDoneProjectTaskDto request,
        CancellationToken cancellationToken)
    {
        var command = new MarkAsDoneCommand(
            id,
            request.Rating);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPost("{id}/cancel")]
    public async Task<IActionResult> Cancel(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new CancelProjectTaskCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [Authorize(Roles = nameof(UserRole.Customer))]
    [HttpPost("{id}/assign")]
    public async Task<IActionResult> Assign(
        Guid id,
        [FromBody] AssignProjectTaskDto request,
        CancellationToken cancellationToken)
    {
        var command = new AssignExecutorCommand(
            id,
            request.ExecutorId);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetProjectTaskByIdQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("customer/{customerId}")]
    public async Task<IActionResult> GetByCustomer(
        Guid customerId,
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetTasksByCustomerQuery(
            customerId,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("published")]
    public async Task<IActionResult> GetPublished(
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetPublishedTasksQuery(
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("{id}/responses")]
    public async Task<IActionResult> GetResponses(
        Guid id,
        CancellationToken cancellationToken)
    {
        var query = new GetTaskResponsesQuery(id);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("assigned/{executorId}")]
    public async Task<IActionResult> GetAssigned(
        Guid executorId,
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetAssignedTasksQuery(
            executorId,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search(
        [FromQuery] string query,
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var isCustomer = _currentUser.IsInRole(nameof(UserRole.Customer));

        var searchQuery = SearchTasksQueryFactory.Create(
            _currentUser,
            isCustomer,
            query,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(searchQuery, cancellationToken);

        return result.ToResponse(this);
    }
}
````

---

## FILE: `Web Api/Controllers/TaskAttachmentsController.cs`

````csharp
﻿using Application.Attachments.Commands.DeleteAttachment;
using Application.Attachments.Commands.UploadAttachment;
using Application.Attachments.Queries;
using Application.Attachments.Queries.GetAttachmentFile;
using Domain.Constants;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/tasks/{taskId}/attachments")]
[Authorize]
public class TaskAttachmentsController : ControllerBase
{
    private readonly IMediator _mediatr;

    public TaskAttachmentsController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet("{attachmentId:guid}/download")]
    public async Task<IActionResult> Download(
        Guid taskId,
        Guid attachmentId,
        CancellationToken cancellationToken)
    {
        var query = new GetAttachmentFileQuery(attachmentId);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpGet]
    public async Task<IActionResult> List(
        Guid taskId,
        CancellationToken cancellationToken)
    {
        var query = new GetTaskAttachmentsQuery(taskId);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost]
    [RequestSizeLimit(AttachmentConstants.MaxSizeBytes)]
    [RequestFormLimits(MultipartBodyLengthLimit = AttachmentConstants.MaxSizeBytes)]
    public async Task<IActionResult> Upload(
        Guid taskId,
        [FromForm] IFormFile file,
        CancellationToken cancellationToken)
    {
        if (file is null || file.Length == 0)
        {
            return BadRequest(ErrorMessages.OriginalFileNameCannotBeEmpty);
        }

        await using var stream = file.OpenReadStream();

        var command = new UploadAttachmentCommand(
            taskId,
            file.FileName,
            file.ContentType,
            file.Length,
            stream);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpDelete("{attachmentId}")]
    public async Task<IActionResult> Delete(
        Guid taskId,
        Guid attachmentId,
        CancellationToken cancellationToken)
    {
        var command = new DeleteAttachmentCommand(attachmentId);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }
}
````

---

## FILE: `Web Api/Controllers/UserActionController.cs`

````csharp
﻿using Application.UserActions.Queries.GetUserActions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests;
using Shared.Enums;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = nameof(UserRole.Admin))]
public class UserActionController : ControllerBase
{
    private readonly IMediator _mediatr;

    public UserActionController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] Guid? userId,
        [FromQuery] int? actionType,
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetUserActionsQuery(
            userId,
            actionType,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }
}
````

---

## FILE: `Web Api/Controllers/UserController.cs`

````csharp
﻿using Application.Users.Commands.BlockUser;
using Application.Users.Commands.ChangeRole;
using Application.Users.Commands.Delete;
using Application.Users.Commands.UnblockUser;
using Application.Users.Queries.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Requests;
using Shared.Dtos.Requests.Users;
using Shared.Enums;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = nameof(UserRole.Admin))]
public class UserController : ControllerBase
{
    private readonly IMediator _mediatr;

    public UserController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpGet]
    public async Task<IActionResult> Get(
        [FromQuery] PageDto request,
        CancellationToken cancellationToken)
    {
        var query = new GetUsersQuery(request.Page, request.PageSize);

        var result = await _mediatr.Send(query, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPatch("{id}/role")]
    public async Task<IActionResult> ChangeRole(
        Guid id,
        [FromBody] ChangeRoleUserDto request,
        CancellationToken cancellationToken)
    {
        var command = new ChangeRoleCommand(id, request.NewRole);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost("{id}/block")]
    public async Task<IActionResult> Block(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new BlockUserCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost("{id}/unblock")]
    public async Task<IActionResult> Unblock(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new UnblockUserCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(
        Guid id,
        CancellationToken cancellationToken)
    {
        var command = new DeleteUserCommand(id);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }
}
````

---

## FILE: `Web Api/ExceptionHandler/GlobalExceptionHandler.cs`

````csharp
﻿using Domain.Constants;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Web_Api.ExceptionHandler;

public class GlobalExceptionHandler : IExceptionHandler
{
    private readonly ILogger<GlobalExceptionHandler> _logger;

    public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
    {
        _logger = logger;
    }

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext,
        Exception exception,
        CancellationToken cancellationToken = default)
    {
        _logger.LogError(
            exception,
            ErrorMessages.GlobalExceptionMessage,
            exception.Message);

        var problemDetails = new ProblemDetails
        {
            Status = StatusCodes.Status500InternalServerError,
            Title = ErrorMessages.ServerError,
            Detail = httpContext.RequestServices.GetRequiredService<IHostEnvironment>().IsDevelopment()
                ? exception.Message
                : ErrorMessages.UnexpectedError
        };

        httpContext.Response.StatusCode = problemDetails.Status.Value;

        await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }
}
````

---

## FILE: `Web Api/Extensions/Constants/SwaggerConstants.cs`

````csharp
﻿namespace Web_Api.Extensions.Constants;

public static class SwaggerConstants
{
    public const string VersionName = "v1";
    public const string Title = "My Web API";
    public const string SchemeName = "Bearer";
    public const string SecuritySchemeName = "Authorization";
    public const string SecurityScheme = "bearer";
    public const string SecurityBearerFormat = "JWT";
    public const string SecurityDescription = "Please enter token";
}
````

---

## FILE: `Web Api/Extensions/CurrentUser.cs`

````csharp
﻿using Application.Interfaces;
using System.Security.Claims;

namespace Web_Api.Extensions;

public class CurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _contextAccessor;

    public CurrentUser(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

    public Guid Id
    {
        get
        {
            var value = _contextAccessor.HttpContext?.User
                .FindFirstValue(ClaimTypes.NameIdentifier);

            return Guid.TryParse(value, out var id) ? id : Guid.Empty;
        }
    }

    public bool IsInRole(string role)
    {
        return _contextAccessor.HttpContext?.User
            .IsInRole(role) ?? false;
    }
}
````

---

## FILE: `Web Api/Extensions/ResultExtensions.cs`

````csharp
﻿using Domain.Constants;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos.Responses;
using Shared.Enums;

namespace Web_Api.Extensions;

public static class ResultExtensions
{
    public static IActionResult ToResponse(
        this Result result,
        ControllerBase controllerBase)
    {
        if (result.IsSuccess)
        {
            return controllerBase.NoContent();
        }

        var (statusCode, title) = StatusSelector(result.Error);

        return controllerBase.Problem(
            detail: result.Message,
            statusCode: statusCode,
            title: title);
    }

    public static IActionResult ToResponse<T>(
        this Result<T> result,
        ControllerBase controllerBase) where T : class
    {
        if (result.IsSuccess)
        {
            return controllerBase.Ok(result.Value);
        }

        var (statusCode, title) = StatusSelector(result.Error);

        return controllerBase.Problem(
            detail: result.Message,
            statusCode: statusCode,
            title: title);
    }

    private static (int StatusCode, string Title) StatusSelector(ErrorType error)
    {
        return error switch
        {
            ErrorType.NotFound => (StatusCodes.Status404NotFound, ErrorMessages.NotFound),
            ErrorType.Validation => (StatusCodes.Status400BadRequest, ErrorMessages.Validation),
            ErrorType.Conflict => (StatusCodes.Status409Conflict, ErrorMessages.Conflict),
            ErrorType.Unauthorized => (StatusCodes.Status401Unauthorized, ErrorMessages.Unauthorized),
            ErrorType.Forbidden => (StatusCodes.Status403Forbidden, ErrorMessages.Forbidden),
            _ => (StatusCodes.Status500InternalServerError, ErrorMessages.ServerError)
        };
    }
}
````

---

## FILE: `Web Api/Extensions/ServiceCollectionExtensions.cs`

````csharp
﻿using Application.Behaviors;
using Application.Interfaces;
using Application.ProjectTasks.Commands.Create;
using Application.Services.FileStorage;
using Application.Services.Hasher;
using Application.Services.JwtGenerator;
using Domain.Config;
using Domain.Interfaces;
using Domain.Interfaces.Chats;
using Domain.Interfaces.Files;
using Domain.Interfaces.ProjectTasks;
using Domain.Interfaces.UserActions;
using Domain.Interfaces.Users;
using Infrastructure;
using Infrastructure.Repositories;
using Infrastructure.Repositories.Chats;
using Infrastructure.Repositories.Files;
using Infrastructure.Repositories.ProjectTasks;
using Infrastructure.Repositories.UserActions;
using Infrastructure.Repositories.Users;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using System.Text;
using Web_Api.Extensions.Constants;

namespace Web_Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSwagger(
        this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc(SwaggerConstants.VersionName, new OpenApiInfo
            {
                Title = SwaggerConstants.Title,
                Version = SwaggerConstants.VersionName
            });

            options.AddSecurityDefinition(SwaggerConstants.SchemeName, new OpenApiSecurityScheme
            {
                Name = SwaggerConstants.SecuritySchemeName,
                Type = SecuritySchemeType.Http,
                Scheme = SwaggerConstants.SecurityScheme,
                BearerFormat = SwaggerConstants.SecurityBearerFormat,
                In = ParameterLocation.Header,
                Description = SwaggerConstants.SecurityDescription
            });

            options.AddSecurityRequirement(document =>
                new OpenApiSecurityRequirement
                {
                    [new OpenApiSecuritySchemeReference(SwaggerConstants.SchemeName, document)] = []
                });
        });

        return services;
    }

    public static IServiceCollection AddConfigurationOptions(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services
            .AddOptions<AppConfig>()
            .Bind(configuration.GetSection(AppConfig.SectionName))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        services
            .AddOptions<JwtSettings>()
            .Bind(configuration.GetSection(JwtSettings.SectionName))
            .ValidateDataAnnotations()
            .ValidateOnStart();

        services
            .AddOptions<FileSettings>()
            .Bind(configuration.GetSection(FileSettings.SectionName))
            .Configure(options =>
            {
                var userRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                var appConfig = configuration.GetSection(AppConfig.SectionName)
                    .Get<AppConfig>();

                options.FullPath = Path.Combine(
                    userRoaming,
                    appConfig!.AppName,
                    options.FileName);
            })
            .ValidateDataAnnotations()
            .ValidateOnStart();

        return services;
    }

    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();

        services.AddScoped<ICurrentUser, CurrentUser>();

        services.AddScoped<IUserActionCommandRepository, UserActionCommandRepository>()
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(TransactionBehaviour<,>))
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(UserActionLoggingBehavior<,>));

        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(typeof(CreateProjectTaskCommand).Assembly));

        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>()
                .AddScoped<IPasswordHasher, PasswordHasher>()
                .AddScoped<IFileStorageService, FileStorageService>();

        return services;
    }
    public static IServiceCollection AddInfrastructureServices(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>((serviceProvider, options) =>
        {
            var appConfig = serviceProvider.GetRequiredService<IOptions<AppConfig>>().Value;

            options.UseSqlServer(appConfig.ConnectionString);
        });

        services.AddScoped<IChatCommandRepository, ChatCommandRepository>()
                .AddScoped<IChatQueryRepository, ChatQueryRepository>();

        services.AddScoped<IProjectTaskCommandRepository, ProjectTaskCommandRepository>()
                .AddScoped<IProjectTaskQueryRepository, ProjectTaskQueryRepository>();

        services.AddScoped<IUserCommandRepository, UserCommandRepository>()
                .AddScoped<IUserQueryRepository, UserQueryRepository>();

        services.AddScoped<IUserActionQueryRepository, UserActionQueryRepository>();

        services.AddScoped<ITaskAttachmentCommandRepository, TaskAttachmentCommandRepository>()
                .AddScoped<ITaskAttachmentQueryRepository, TaskAttachmentQueryRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }

    public static IServiceCollection AddJwtBearer(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var jwtSettings = configuration.GetSection(JwtSettings.SectionName)
            .Get<JwtSettings>();

        services.AddAuthentication()
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings!.Key)),
                    ValidAudiences = jwtSettings.ValidAudiences,
                    ValidIssuers = jwtSettings.ValidIssuers,
                };
            });

        return services;
    }
}
````

---

## FILE: `Web Api/Program.cs`

````csharp
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Web_Api.ExceptionHandler;
using Web_Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddProblemDetails();
builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

var configuration = builder.Configuration;

builder.Services
    .AddConfigurationOptions(configuration)
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddJwtBearer(builder.Configuration)
    .AddSwagger();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    dbContext.Database.Migrate();
}

app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapSwagger();
    app.MapSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();
````

---

## FILE: `Web Api/Properties/launchSettings.json`

````json
﻿{
  "$schema": "https://json.schemastore.org/launchsettings.json",
  "profiles": {
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": false,
      "applicationUrl": "http://localhost:5126",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "https": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": false,
      "applicationUrl": "https://localhost:7025;http://localhost:5126",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
````

---

## FILE: `Web Api/Web Api.csproj`

````text
﻿<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>Web_Api</RootNamespace>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="MediatR" Version="14.2.0" />
    <PackageReference Include="Microsoft.AspNetCore.Authentication.JwtBearer" Version="10.0.13" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="10.0.13">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Swashbuckle.AspNetCore" Version="10.3.0" />
	<PackageReference Include="System.Security.Cryptography.Pkcs" Version="10.0.13" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\Application\Application.csproj" />
    <ProjectReference Include="..\Domain\Domain.csproj" />
    <ProjectReference Include="..\Infrastructure\Infrastructure.csproj" />
  </ItemGroup>

  <ProjectExtensions><VisualStudio><UserProperties appsettings_1json__JsonSchema="" /></VisualStudio></ProjectExtensions>

</Project>
````

---

## FILE: `Web/appsettings.Development.json`

````json
{
  "DetailedErrors": true,
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  }
}
````

---

## FILE: `Web/appsettings.json`

````json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
````

---

## FILE: `Web/Pages/Error.cshtml`

````text
﻿@page
@model ErrorModel
@{
    ViewData["Title"] = "Error";
}

<h1 class="text-danger">Error.</h1>
<h2 class="text-danger">An error occurred while processing your request.</h2>

@if (Model.ShowRequestId)
{
    <p>
        <strong>Request ID:</strong> <code>@Model.RequestId</code>
    </p>
}

<h3>Development Mode</h3>
<p>
    Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
````

---

## FILE: `Web/Pages/Error.cshtml.cs`

````csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace Web.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    public void OnGet()
    {
        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    }
}

````

---

## FILE: `Web/Pages/Index.cshtml`

````text
﻿@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

<div class="text-center">
    <h1 class="display-4">Welcome</h1>
    <p>Learn about <a href="https://learn.microsoft.com/aspnet/core">building Web apps with ASP.NET Core</a>.</p>
</div>
````

---

## FILE: `Web/Pages/Index.cshtml.cs`

````csharp
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages;

public class IndexModel : PageModel
{
    public void OnGet()
    {

    }
}
````

---

## FILE: `Web/Pages/Privacy.cshtml`

````text
﻿@page
@model PrivacyModel
@{
    ViewData["Title"] = "Privacy Policy";
}
<h1>@ViewData["Title"]</h1>

<p>Use this page to detail your site's privacy policy.</p>
````

---

## FILE: `Web/Pages/Privacy.cshtml.cs`

````csharp
﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.Pages;

public class PrivacyModel : PageModel
{
    public void OnGet()
    {
    }
}

````

---

## FILE: `Web/Pages/Shared/_Layout.cshtml`

````text
﻿<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - Web</title>
    <script type="importmap"></script>
    <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="~/css/site.css" asp-append-version="true" />
    <link rel="stylesheet" href="~/Web.styles.css" asp-append-version="true" />
</head>
<body>
    <header>
        <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
            <div class="container">
                <a class="navbar-brand" asp-area="" asp-page="/Index">Web</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                        aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="navbar-collapse collapse d-sm-inline-flex justify-content-between">
                    <ul class="navbar-nav flex-grow-1">
                        <li class="nav-item">
                            <a class="nav-link text-dark" asp-area="" asp-page="/Index">Home</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link text-dark" asp-area="" asp-page="/Privacy">Privacy</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <div class="container">
        <main role="main" class="pb-3">
            @RenderBody()
        </main>
    </div>

    <footer class="border-top footer text-muted">
        <div class="container">
            &copy; 2026 - Web - <a asp-area="" asp-page="/Privacy">Privacy</a>
        </div>
    </footer>

    <script src="~/lib/jquery/dist/jquery.min.js"></script>
    <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    <script src="~/js/site.js" asp-append-version="true"></script>

    @await RenderSectionAsync("Scripts", required: false)
</body>
</html>
````

---

## FILE: `Web/Pages/Shared/_Layout.cshtml.css`

````css
﻿/* Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
for details on configuring this project to bundle and minify static web assets. */

a.navbar-brand {
  white-space: normal;
  text-align: center;
  word-break: break-all;
}

a {
  color: #0077cc;
}

.btn-primary {
  color: #fff;
  background-color: #1b6ec2;
  border-color: #1861ac;
}

.nav-pills .nav-link.active, .nav-pills .show > .nav-link {
  color: #fff;
  background-color: #1b6ec2;
  border-color: #1861ac;
}

.border-top {
  border-top: 1px solid #e5e5e5;
}
.border-bottom {
  border-bottom: 1px solid #e5e5e5;
}

.box-shadow {
  box-shadow: 0 .25rem .75rem rgba(0, 0, 0, .05);
}

button.accept-policy {
  font-size: 1rem;
  line-height: inherit;
}

.footer {
  position: absolute;
  bottom: 0;
  width: 100%;
  white-space: nowrap;
  line-height: 60px;
}
````

---

## FILE: `Web/Pages/Shared/_ValidationScriptsPartial.cshtml`

````text
﻿<script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
<script src="~/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js"></script>
````

---

## FILE: `Web/Pages/_ViewImports.cshtml`

````text
﻿@using Web
@namespace Web.Pages
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
````

---

## FILE: `Web/Pages/_ViewStart.cshtml`

````text
﻿@{
    Layout = "_Layout";
}
````

---

## FILE: `Web/Program.cs`

````csharp
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
````

---

## FILE: `Web/Properties/launchSettings.json`

````json
{
  "$schema": "https://json.schemastore.org/launchsettings.json",
  "profiles": {
    "http": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "http://localhost:5123",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "https": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "applicationUrl": "https://localhost:7264;http://localhost:5123",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}
````

---

## FILE: `Web/Web.csproj`

````text
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

</Project>
````

---

## FILE: `Web/wwwroot/css/site.css`

````css
html {
  font-size: 14px;
}

@media (min-width: 768px) {
  html {
    font-size: 16px;
  }
}

.btn:focus, .btn:active:focus, .btn-link.nav-link:focus, .form-control:focus, .form-check-input:focus {
  box-shadow: 0 0 0 0.1rem white, 0 0 0 0.25rem #258cfb;
}

html {
  position: relative;
  min-height: 100%;
}

body {
  margin-bottom: 60px;
}

.form-floating > .form-control-plaintext::placeholder, .form-floating > .form-control::placeholder {
  color: var(--bs-secondary-color);
  text-align: end;
}

.form-floating > .form-control-plaintext:focus::placeholder, .form-floating > .form-control:focus::placeholder {
  text-align: start;
}
````

---

## FILE: `Web/wwwroot/js/site.js`

````javascript
﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
````

---

## FILE: `Web/wwwroot/lib/bootstrap/LICENSE`

````text
The MIT License (MIT)

Copyright (c) 2011-2021 Twitter, Inc.
Copyright (c) 2011-2021 The Bootstrap Authors

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
````

---

## FILE: `Web/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt`

````text
The MIT License (MIT)

Copyright (c) .NET Foundation and Contributors

All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
````

---

## FILE: `Web/wwwroot/lib/jquery-validation/LICENSE.md`

````markdown
The MIT License (MIT)
=====================

Copyright Jörn Zaefferer

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
````

---

## FILE: `Web/wwwroot/lib/jquery/LICENSE.txt`

````text

Copyright OpenJS Foundation and other contributors, https://openjsf.org/

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
````

---

## FILE: `wep-api.dockerfile`

````text
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["Web Api/Web Api.csproj", "Web Api/"]
COPY ["Application/Application.csproj", "Application/"]
COPY ["Domain/Domain.csproj", "Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "Infrastructure/"]
COPY ["Shared/Shared.csproj", "Shared/"]

COPY ["Web Api/", "Web Api/"]
COPY ["Application/", "Application/"]
COPY ["Domain/", "Domain/"]
COPY ["Infrastructure/", "Infrastructure/"]
COPY ["Shared/", "Shared/"]

RUN dotnet restore "Web Api/Web Api.csproj"

WORKDIR "/src/Web Api"
RUN dotnet publish "Web Api.csproj" -c Release -o "/app/dlls"

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR "/app"
COPY --from=build "/app/dlls" .
ENTRYPOINT ["dotnet", "Web Api.dll"]
````
