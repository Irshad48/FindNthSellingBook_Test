# Book Sale - Find Nth Lowest Selling Book

## Problem Description  
You are given a list of book sales, where each number in the list represents the number of copies sold for a specific book. The task is to find the **Nth lowest selling book**. The sales list may contain duplicate values, so you need to find the Nth most frequent sale count, not the Nth smallest sale. 

## Rules  
1. The input list can have duplicate sales values.
2. You need to count the occurrences of each sale amount and then return the Nth lowest selling book.
3. If there is no Nth lowest selling book, return 0.
4. If the inputs are invalid (null list, empty list, or N is zero or negative), throw an `InvalidOperationException`.

## Explanation  

The solution involves identifying the Nth lowest selling book based on the frequency of its sale count. The approach uses a dictionary to count the frequency of each sale value and sorts the values by their frequencies to find the Nth lowest. Here’s a detailed breakdown of the solution:

### 1. **Input Validation**  
First, we check if the `sales` array is null or empty, or if the value of `n` is invalid (either 0 or negative). If any of these conditions are met, we throw an `InvalidOperationException`. This ensures the function handles incorrect inputs gracefully.

---

### 2. **Counting Sales**  
The program uses a `Dictionary<int, int>` to store the sale amount as the key and its frequency (count) as the value. This helps in efficiently counting how often each sale value appears in the list.

---

### 3. **Sorting and Finding the Nth Lowest**  
We use LINQ to get distinct sales values, and then count the occurrences of each distinct sale amount. After this, we sort the sale values by their frequency in ascending order. The sorted list helps us easily access the Nth lowest sale count.

---

### 4. **Edge Cases**  
If the function doesn’t find the Nth lowest selling book, it returns 0. This ensures that if there are fewer than N different sale counts, we handle the case appropriately.

---

### Explanation of Solution:

1. **Input Validation**:
   - First, the function checks if the `sales` array is null or empty, or if the value of `n` is invalid. If so, it throws an exception.

2. **Sale Count Using Dictionary**:
   - A `Dictionary<int, int>` is used to count how many times each sale amount appears in the array. Each unique sale count is stored as the key, and the frequency of that sale is stored as the value.

3. **Sorting Sales**:
   - The dictionary is then sorted first by the frequency (ascending order) and then by the sale value itself (also in ascending order). This ensures that the book with the lowest sales frequency is considered first.

4. **Finding the Nth Lowest Selling Book**:
   - The sorted list is checked to find the Nth lowest selling book. If the list contains fewer than N books, the function returns 0 as an indication that the Nth lowest sale doesn't exist.

5. **Edge Case Handling**:
   - The function gracefully handles situations where the inputs are invalid or where the Nth lowest selling book doesn't exist, by returning 0 in these cases.

---

### Example:

Given the sales data `{ 11, 99, 44, 77, 99, 11, 33, 44, 77, 11, 99, 44, 11, 99, 11 }` and `n = 2`, the program will output `44` because the second lowest selling book (based on frequency) is the one with 44 sales. The frequencies of sales are:
- 11: 6 occurrences
- 99: 4 occurrences
- 44: 3 occurrences
- 77: 2 occurrences
- 33: 1 occurrence

The Nth lowest selling book is the one with the second lowest frequency, which is `44` (3 occurrences).
