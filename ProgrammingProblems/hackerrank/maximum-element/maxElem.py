# Create a list that will contain our stack values
stackTest = []

# Create a list that will only contain our maximum values
currentMax = []

for i in range(int(input())):
    line = list(map(int, input().split()))

    # If stdin is 1, append whatever value follows it to our stack
    if(line[0] == 1):
        stackTest.append(line[1])

        # If the currentMax list is empty, append the value to the currentMax list
        if not currentMax:
            currentMax.append(line[1])

        # If the currentMax list is not empty, compare to the currentMax value and determine whether or not the value should be replaced
        else:
            if(currentMax[0] < line[1]):
                currentMax.pop()
                currentMax.append(line[1])

    # If stdin is 2, remove last added value from our stack
    elif(line[0] == 2):

        # Get the value to be removed and store it in check
        check = stackTest[len(stackTest)-1]

        # Remove the value from stackTest
        stackTest.pop(len(stackTest)-1)

        # If the currentMax value is equal to the value being removed, remove that value from currentMax as well
        if(currentMax[0] == check):
            currentMax.pop()

            # So long that stackTest is not empty, find a new maximum from stackTest and set that as our new currentMax
            if not stackTest:
                pass
            else:
                maxItem = max(stackTest)
                currentMax.append(maxItem)

    # Print our currentMax value
    elif(line[0] == 3):
        print(currentMax[0])

'''
1 x  -Push the element x into the stack.
2    -Delete the element present at the top of the stack.
3    -Print the maximum element in the stack.

The first line of input contains an integer, . The next  lines each contain an above mentioned query. (It is guaranteed that each query is valid.)

For each type  query, print the maximum element in the stack on a new line.
'''
