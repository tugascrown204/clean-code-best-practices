# Before refactoring:
# def get_user_info(user):
#     return f'{user.name}, {user.age} years old'

# After refactoring:

def format_user_info(user):
    return f'{user.name}, {user.age} years old'

# Usage:
# print(format_user_info(some_user))
