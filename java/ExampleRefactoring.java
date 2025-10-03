// Before refactoring:
// public String getUserInfo(User user) { return user.getName() + ", " + user.getAge() + " years old"; }

// After refactoring:

public String formatUserInfo(User user) {
    return user.getName() + ", " + user.getAge() + " years old";
}

// Usage:
// System.out.println(formatUserInfo(someUser));
