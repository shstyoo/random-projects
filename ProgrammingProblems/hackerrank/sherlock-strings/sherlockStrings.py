def sherlockString(s):
		# Split string into list of characters
	_s = list(s)

	# Initialize our dictionary with key: letter, value: number of occurence
	dict = {}

	# Iterate through string
	for item in _s:

		# If a letter has already been viewed, increment counter by 1
		if item in dict:
			dict[item] = dict[item] + 1

		# If a letter hasn't been viewed, create a dictionary entry for letter with occurence 1
		else:
			dict[item] = 1

	# DEBUG print(dict)

	# Initialize our second dictionary with key: number of occurences, value: number of, number of occurences
	tempDict = {}

	# Iterate through each value in our original dictionary with the letters
	for key, value in dict.items():

		# If a value has already been viewed, increment counter by 1
		if value in tempDict:
			tempDict[value] = tempDict[value] + 1

		# If a value hasn't already been viewed, create dictionary entry for value with occurence 1
		else:
			tempDict[value] = 1

	# DEBUG print(tempDict)

	# Create list containing values of occurence from tempDict
	eval = []
	for key, value in tempDict.items():
		eval.append(value)

	# If there is one entry in tempDict (e.g. string is all one letter) return "YES"
	if(len(tempDict) == 1):
		print("YES")
		return("YES")

	# If there are two entries in tempDict, do more tests
	elif(len(tempDict) == 2):

		# If the list containing the values of occurence from tempDict is of size 2, and contains the value 1 return "YES"
		if 1 in eval:
			print("YES")
			return("YES")

	# Otherwise Fail all other cases. Return "NO"
		else:
			print("NO")
			return("NO")
	else:
		print("NO")
		return("NO")

'''

::::::INSTRUCTIONS::::::

A "valid" string is a string  such that for all distinct characters in  each such character occurs the same number of times in .

For example, aabb is a valid string because the frequency of both characters a and b is , whereas aabbc is not a valid string because the frequency of characters a, b, and c is not the same.

Watson gives a string  to Sherlock and asks him to remove some characters from the string such that the new string is a "valid" string.

Sherlock wants to know from you if it's possible to be done with less than or equal to one removal.

Input Format
----
The first and only line contains , the string Watson gives to Sherlock.

Constraints
----
String  contains lowercase letters only ().

Output Format
----
Output YES if string  can be converted to a "valid" string by removing less than or equal to one character.
Else, output NO.
'''

# TEST STRINGS

t1 = 'jtqgugmcsxvdwidtcyqpogkdifapuloqykjfxruvfrshcehekoiwbpbrprahwvhliglyxynjotbaswnnnmxbkmcftvsdqajemeul'
# OUTPUT = YES

t2 = 'aabbcd'
# OUTPUT = NO

t3 = 'hfchdkkbfifgbgebfaahijchgeeeiagkadjfcbekbdaifchkjfejckbiiihegacfbchdihkgbkbddgaefhkdgccjejjaajgijdkd'
# OUTPUT = YES

t4 = 'ibfdgaeadiaefgbhbdghhhbgdfgeiccbiehhfcggchgghadhdhagfbahhddgghbdehidbibaeaagaeeigffcebfbaieggabcfbiiedcabfihchdfabifahcbhagccbdfifhghcadfiadeeaheeddddiecaicbgigccageicehfdhdgafaddhffadigfhhcaedcedecafeacbdacgfgfeeibgaiffdehigebhhehiaahfidibccdcdagifgaihacihadecgifihbebffebdfbchbgigeccahgihbcbcaggebaaafgfedbfgagfediddghdgbgehhhifhgcedechahidcbchebheihaadbbbiaiccededchdagfhccfdefigfibifabeiaccghcegfbcghaefifbachebaacbhbfgfddeceababbacgffbagidebeadfihaefefegbghgddbbgddeehgfbhafbccidebgehifafgbghafacgfdccgifdcbbbidfifhdaibgigebigaedeaaiadegfefbhacgddhchgcbgcaeaieiegiffchbgbebgbehbbfcebciiagacaiechdigbgbghefcahgbhfibhedaeeiffebdiabcifgccdefabccdghehfibfiifdaicfedagahhdcbhbicdgibgcedieihcichadgchgbdcdagaihebbabhibcihicadgadfcihdheefbhffiageddhgahaidfdhhdbgciiaciegchiiebfbcbhaeagccfhbfhaddagnfieihghfbaggiffbbfbecgaiiidccdceadbbdfgigibgcgchafccdchgifdeieicbaididhfcfdedbhaadedfageigfdehgcdaecaebebebfcieaecfagfdieaefdiedbcadchabhebgehiidfcgahcdhcdhgchhiiheffiifeegcfdgbdeffhgeghdfhbfbifgidcafbfcd'
# OUTPUT = YES

t5 = 'tfgyrknpgngtqgjccbyctwdcymwrcjtpoaflkeoxfxijxkngpjoofggsozftkpgxakptmzjxugavazwllxdtrjrrbjmrqwfxaby'
# OUTPUT = NO
