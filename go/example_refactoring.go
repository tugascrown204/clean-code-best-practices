// Before refactoring:
// func getUserInfo(user User) string { return user.Name + ", " + user.Age + " years old" }

// After refactoring:

func formatUserInfo(user User) string {
    return user.Name + ", " + user.Age + " years old"
}

// Usage:
// fmt.Println(formatUserInfo(someUser))
