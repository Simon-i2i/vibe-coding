# Sorting Algorithms in .NET Core 8

Welcome! This repository is a step-by-step guide to learning sorting algorithms, starting from the simplest and progressing to more advanced ones, including those used for big data. Each algorithm includes:

- Simple, well-commented C# code
- Explanations for every step
- Pros, cons, and limitations
- Designed for .NET Core 8

---

## Algorithms Covered (in order):

1. **Bubble Sort**
2. **Selection Sort**
3. **Insertion Sort**
4. **Shell Sort**
5. **Merge Sort**
6. **Quick Sort**
7. **Heap Sort**
8. **Counting Sort**
9. **Bucket Sort**
10. **Radix Sort**
11. **TimSort**
12. **External Merge Sort** (for very large/big data)
13. **Bitonic Sort** (parallel sorting, used in high-performance computing)

---

## Example Structure

```
Sorting/
  BubbleSort.cs
  SelectionSort.cs
  InsertionSort.cs
  ShellSort.cs
  MergeSort.cs
  QuickSort.cs
  HeapSort.cs
  CountingSort.cs
  BucketSort.cs
  RadixSort.cs
  TimSort.cs
  ExternalMergeSort.cs
  BitonicSort.cs
  README.md
```

---

## Algorithm Summaries

| Algorithm           | Time Complexity (Best / Avg / Worst) | Pros                                                                 | Cons / Limitations                                                      |
|---------------------|--------------------------------------|----------------------------------------------------------------------|-------------------------------------------------------------------------|
| **Bubble Sort**     | O(n) / O(n²) / O(n²)                 | Easiest to understand; good for teaching basics                      | Very slow for large datasets; not used in practice                      |
| **Selection Sort**  | O(n²) / O(n²) / O(n²)                | Simple; easy to implement; no extra memory needed                    | Inefficient for large lists; not stable                                 |
| **Insertion Sort**  | O(n) / O(n²) / O(n²)                 | Efficient for small or nearly sorted data; in-place; stable          | Slow for large datasets                                                 |
| **Shell Sort**      | O(n log n) / O(n^1.5) / O(n²)        | Faster than Bubble/Insertion; easy to implement                      | Not stable; performance depends on gap sequence                         |
| **Merge Sort**      | O(n log n) / O(n log n) / O(n log n) | Always O(n log n); stable; good for linked lists                     | Uses extra memory (O(n)); slower for small lists                        |
| **Quick Sort**      | O(n log n) / O(n log n) / O(n²)      | Very fast in practice; in-place; O(n log n) average                  | Worst case O(n²); not stable; performance depends on pivot choice       |
| **Heap Sort**       | O(n log n) / O(n log n) / O(n log n) | O(n log n) always; in-place; no extra memory                         | Not stable; slower than QuickSort in practice                           |
| **Counting Sort**   | O(n+k) / O(n+k) / O(n+k)             | O(n+k) time; very fast for small integer ranges                      | Only works for integers in a known range; uses extra memory             |
| **Bucket Sort**     | O(n+k) / O(n+k) / O(n²)              | Good for uniformly distributed data; can be very fast                | Not good for non-uniform data; needs extra memory                       |
| **Radix Sort**      | O(nk) / O(nk) / O(nk)                | O(nk) time; good for large numbers/strings; not comparison-based     | Only for integers/strings; needs stable sort as subroutine              |
| **TimSort**         | O(n) / O(n log n) / O(n log n)       | Hybrid (Merge + Insertion); used in Python/Java; very efficient      | Complex to implement; not always best for all data types                |
| **External Merge**  | O(n log n) / O(n log n) / O(n log n) | Handles data larger than memory; used in databases/big data          | Slower due to disk I/O; complex implementation                          |
| **Bitonic Sort**    | O(log² n) / O(log² n) / O(log² n)    | Highly parallelizable; used in hardware/parallel computing           | Not efficient for general use; mainly for parallel systems              |

---

## How to Use

- Each algorithm is in its own file for clarity.
- Code is written in small, easy-to-understand steps.
- Comments explain what each part does.
- Suitable for new developers and those new to algorithms.

---

## Getting Started

1. Clone this repository.
2. Open the solution in Visual Studio 2022+ or VS Code.
3. Run any file to see the algorithm in action.

---

## Guidance & Advanced Tips: Choosing the Right Sorting Algorithm

**1. Small Arrays (n < 20):**
   - Use **Insertion Sort** or **Selection Sort**. They are simple and have low overhead.

**2. Nearly Sorted Arrays:**
   - **Insertion Sort** is very efficient (O(n)) for nearly sorted data.
   - **TimSort** (used in Python/Java) is designed for such cases.

**3. Large Arrays in Memory:**
   - **Quick Sort** is usually fastest for general data, but beware of worst-case O(n²) (use random or median-of-three pivot).
   - **Merge Sort** is stable and always O(n log n), but uses extra memory.
   - **Heap Sort** is in-place and O(n log n), but slower in practice than Quick Sort.

**4. Linked Lists:**
   - **Merge Sort** is preferred, as it does not require random access.

**5. Large Range of Integers:**
   - **Counting Sort** (if range is not too large and all values are non-negative).
   - **Radix Sort** for large numbers or strings (non-comparison-based).

**6. Uniformly Distributed Data:**
   - **Bucket Sort** can be very fast if data is uniformly distributed.

**7. Data Too Large for Memory:**
   - **External Merge Sort** is used in databases and big data systems (splits data into chunks, sorts, and merges).

**8. Real-Time/Embedded Systems:**
   - **Heap Sort** is good for predictable O(n log n) time and in-place sorting.

**9. Parallel/Distributed Systems:**
   - **Bitonic Sort** and other parallel sorts are used in hardware and high-performance computing.

---

### Famous Interview Scenarios

- **"Sort a million integers, all between 1 and 10,000"**  
  Use **Counting Sort**.

- **"Sort a huge file that doesn't fit in memory"**  
  Use **External Merge Sort**.

- **"Sort a list of objects by multiple keys (e.g., last name, then first name)"**  
  Use a **stable sort** (Merge Sort, TimSort).

- **"Sort a nearly sorted array with a few elements out of place"**  
  Use **Insertion Sort** or **TimSort**.

- **"Sort a linked list"**  
  Use **Merge Sort**.

- **"Sort a list of strings"**  
  Use **Radix Sort** (for fixed-length strings), or a stable comparison sort.

---

### Advanced Tips

- **Always prefer stable sorts when you need to preserve the order of equal elements.**
- **For best Quick Sort performance, use a randomized or median-of-three pivot.**
- **TimSort is the default in Python and Java because it adapts to real-world data patterns.**
- **For parallel hardware, Bitonic Sort is used, but not for general software.**
- **For small arrays, the overhead of O(n log n) sorts is often worse than simple O(n²) sorts.** 

---

## Sorting Interview Questions & Answers

- **What is the difference between stable and unstable sorting algorithms? Give examples.**  
  A: A stable sort preserves the relative order of equal elements (e.g., if two objects have the same key, they remain in the same order after sorting). Examples of stable sorts: Merge Sort, Insertion Sort, Bubble Sort, TimSort, Counting Sort. Unstable sorts: Quick Sort, Heap Sort, Selection Sort.

- **When would you use Merge Sort over Quick Sort?**  
  A: Use Merge Sort when you need a stable sort or are sorting linked lists. Merge Sort guarantees O(n log n) time and is stable, while Quick Sort is not stable and can degrade to O(n²) in the worst case. Merge Sort is also preferred for external sorting (large data on disk).

- **How does Quick Sort achieve O(n log n) average time, and what causes its O(n²) worst case?**  
  A: Quick Sort partitions the array around a pivot, recursively sorting subarrays. If the pivot divides the array evenly, the depth is log n, and each level does O(n) work, giving O(n log n) average time. The worst case (O(n²)) occurs when the pivot is always the smallest or largest element, leading to unbalanced partitions (e.g., already sorted data with a bad pivot choice).

- **How would you sort a nearly sorted (almost sorted) array efficiently?**  
  A: Use Insertion Sort or TimSort. Insertion Sort runs in O(n) time for nearly sorted data. TimSort (used in Python/Java) is designed to exploit existing order and is very efficient for such cases.

- **How do you sort a very large dataset that doesn't fit in memory?**  
  A: Use External Merge Sort. This algorithm splits data into manageable chunks, sorts each chunk in memory, writes them to disk, and then merges the sorted chunks.

- **What sorting algorithm would you use for sorting integers in a small, known range?**  
  A: Use Counting Sort. It is very fast (O(n + k)) for small ranges and is stable, but only works for integers (or objects that can be mapped to integers).

- **How do you sort linked lists efficiently?**  
  A: Use Merge Sort. It does not require random access and can be implemented efficiently for linked lists, maintaining O(n log n) time and stability.

- **What is the best sorting algorithm for real-time systems?**  
  A: Heap Sort is often used because it guarantees O(n log n) time and is in-place, providing predictable performance.

- **How do you sort data in parallel or distributed systems?**  
  A: Use parallel algorithms like Bitonic Sort, Odd-Even Merge Sort, or parallelized versions of Merge/Quick Sort. Bitonic Sort is highly parallelizable and used in hardware.

- **What is the difference between comparison-based and non-comparison-based sorting algorithms?**  
  A: Comparison-based sorts (e.g., Quick Sort, Merge Sort, Heap Sort) compare elements to determine order and have a lower bound of O(n log n). Non-comparison-based sorts (e.g., Counting Sort, Radix Sort, Bucket Sort) use properties of the data (like digits or values) and can achieve linear time under certain conditions.

- **How would you sort a list of strings or custom objects?**  
  A: Use a stable comparison-based sort (e.g., Merge Sort, TimSort) and provide a custom comparator for the desired order. For fixed-length strings, Radix Sort can be used.

- **How do you choose a pivot in Quick Sort, and why does it matter?**  
  A: Pivot choice affects partition balance. Good strategies: random pivot, median-of-three (median of first, middle, last elements). A poor pivot (always smallest/largest) leads to unbalanced partitions and O(n²) time.

- **What is TimSort and why is it used in Python/Java?**  
  A: TimSort is a hybrid sorting algorithm (Merge + Insertion Sort) designed for real-world data. It detects and exploits existing order (runs), is stable, and very efficient for partially sorted data. It is the default sort in Python and Java.

- **How do you sort data that is being streamed (cannot be stored fully in memory)?**  
  A: Use online/streaming algorithms like insertion into a min-heap of fixed size (for top-k), or external sorting techniques. For full sorting, buffer chunks, sort, and merge as in External Merge Sort.

---