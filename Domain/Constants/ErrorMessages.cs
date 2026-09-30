namespace Domain.Constants;

public static class ErrorMessages
{
    public const string EntityHasAlreadyDeleted = "Entity has alredy deleted";

    public const string TitleCannotBeEmpty = "Title can't be empty";
    public const string DescriptionCannotBeEmpty = "Description can't be empty";
    public const string PriceConnotBeNegative = "Price must be greater than 0";
    public const string FutureDateTime = "StartsAt and EndsAt must be in the future";

    public const string PasswordCannotBeEmpty = "User password can't be empty";
    public const string PasswordHashCannotBeEmpty = "User passwordhash can't be empty";
    public const string UserNameCannotBeEmpty = "User name can't be empty";
    public const string CannotEditInProgressOrDone = "Can't edit in progress or done";
    public const string CustomerMustBeSame = "Customer must be same";
    public const string OnlyCustomerCanAssign = "Only customer can assign to project task";

    public const string ProjectMustBeInProgress = "Project must be in progress to do done";
    public const string OnlyPublishedTaskCanBeAssigned = "Only a published task can be assigned";
    public const string MustBePublishedToRespond = "Project task must be published to respond";
    public const string CustomerCannotRespond = "Customer cannot respond to his own project task";

    public const string MessageTextCannotBeEmpty = "Message text cannot be empty";

    public const string ExecutorMustBeAtRespondedCollection = "Executor must be at responded collection";

    public const string ProjectTaskNotFound = "Task not found";
    public const string UserNotFound = "User not found";
    public const string ChatNotFound = "Chat not found";

    public const string ProjectTaskByCustomerNotFound = "Project task by customer zero elements";
    public const string UsersNotFound = "Users not found";
    public const string UsersAlreadyExists = "User already exists";

    public const string ChatAlreadyExists = "Chat already exists";

    public const string IncorrectLoginOrPassword = "Incorrect login or password";
}
