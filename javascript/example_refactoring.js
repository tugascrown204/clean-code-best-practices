// Before refactoring:
// function getUserInfo(user) { return user.name + ', ' + user.age + ' years old'; }

// After refactoring:

function formatUserInfo(user) {
    return `${user.name}, ${user.age} years old`;
}

// Usage:
// console.log(formatUserInfo(someUser));
