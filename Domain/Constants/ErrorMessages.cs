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

    public const string ProjectTaskByCustomerNotFound = "Project task by customer zero elements";
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
    public const string CannotAttachToClosedTask = "Cannot attach files to a closed task.";
    public const string OnlyParticipantsCanAttach = "Only the customer or the executor can attach files to the task.";
    public const string OnlyUploaderCanDeleteAttachment = "Only the uploader can delete the attachment.";
    public const string TaskAttachmentNotFound = "Attachment not found.";
}
