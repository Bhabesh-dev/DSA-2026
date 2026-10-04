def is_palindrome():

    input = "madam"
    left ,right  = 0, len(input)-1

    while left < right:
        if input[left]!= input[right]:
            print("Not a Palindrome!")
            return
        left+=1
        right-=1

    print("Valid Palindrome")


if __name__ =="__main__":
    is_palindrome()
