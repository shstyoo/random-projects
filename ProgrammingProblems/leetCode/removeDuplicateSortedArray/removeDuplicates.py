'''
Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.

Do not allocate extra space for another array, you must do this in place with constant memory.

For example,
Given input array nums = [1,1,2],

Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively. It doesn't matter what you leave beyond the new length.
'''

class Solution(object):
    def removeDuplicates(self, nums):
        dictKey = {'base': 0}
        for item in nums:
            if item in dictKey:
                itemIndex = nums.index(item)
                dictKey['base'] = dictKey['base'] + 1
                nums.pop(itemIndex)
                nums.insert(itemIndex, 'base')
            else:
                dictKey[item] = 1
        for i in range(dictKey['base']):
            nums.remove('base')
        return nums.sort()
