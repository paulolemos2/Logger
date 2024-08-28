# Logger
Logger app for assessment purpose.

# Test Scenarios:

TC001: Log an Information Message
Description: Verify function correctly logs an information message.

Execution Steps:

Call the function entering the following messages: ("application.log", "User logged in", "INFO").
Check the file application.log.

Expected Result:

The file application.log should contain a format "[YYYY-MM-DD HH:mm:ss]" "[INFO]" "User logged in"


TC002: Log Multiple Messages
Description: function logs multiple messages, one after the other.

Execution Steps:

Call the function entering the following messages: ("application.log", "User logged in", "INFO").
Call the function entering the following messages: ("application.log", "Failed login attempt", "WARNING").
Check the file application.log.

Expected Result:

The file application.log should contain two lines in the format:
"[YYYY-MM-DD HH:mm:ss]" "[INFO]" "User logged in"
"[YYYY-MM-DD HH:mm:ss]" "[WARNING]" "Failed login attempt"


TC003: Log File Creation
Description: function creates the log file if it doesn´t already exist.

Execution Steps:

Ensure the file application.log doesn´t exist.
Call the function entering the following messages: ("application.log", "Log file created", "INFO").
Check if the file application.log is created with content.

Expected Result:

The file application.log should be created with content.


TC004: Logging an Empty Message
Description: Verify that the function handles an empty message string appropriately.

Execution Steps:

Call the function entering the following messages: ("application.log", "", "INFO").
Check the content of the file application.log.

Expected Result:

The file application.log should contain a line in the expected format.


TC005: Log Entries Across Multiple Executions
Description: Verify that the function preserves previous log entries when logging new messages.

Execution Steps:

Call the function entering the following messages: ("application.log", "First log entry", "INFO").
Execute the program again and call the function entering the following messages: ("application.log", "Second log entry", "WARNING").
Check the content of the file application.log.

Expected Result:

The file application.log should contain both log entries.
