namespace WebApiExceptionHandling.Response
{
    public enum ErrorResponseStatusCode
    {
        Unhandled,
        Validation,
        Core,
        Concurrency,
        EntityDoesntExist,
        UniqueConstraint,
        RequireApprovalExpected,
        NoAccessToApprove,
        LicencingApiError,
        KeepAliveError,
        MethodNotAllowedError,
        FileNotFound,
    }
}