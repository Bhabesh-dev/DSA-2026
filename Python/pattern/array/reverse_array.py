
def reverse_array():

    input =[1,2,3,4,5,6]

    left , right = 0, len(input)-1
    print(input)
    while(left < right):
        input[left] , input[right] = input[right], input[left]
        left+=1
        right-=1

    print(input)


if __name__ =="__main__":
    reverse_array()