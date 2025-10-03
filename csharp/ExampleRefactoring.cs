// Before refactoring:
// public string GetUserInfo(User user) { return user.Name + ", " + user.Age + " years old"; }

// After refactoring:

public string FormatUserInfo(User user) {
    return user.Name + ", " + user.Age + " years old";
}

// Usage:
// Console.WriteLine(FormatUserInfo(someUser));
