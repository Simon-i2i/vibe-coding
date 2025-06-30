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
| **Bubble Sort**     | O(n) / O(n²) / O(n²)                | Easiest to understand; good for teaching basics                      | Very slow for large datasets; not used in practice                      |
| **Selection Sort**  | O(n²) / O(n²) / O(n²)               | Simple; easy to implement; no extra memory needed                    | Inefficient for large lists; not stable                                 |
| **Insertion Sort**  | O(n) / O(n²) / O(n²)                | Efficient for small or nearly sorted data; in-place; stable          | Slow for large datasets                                                 |
| **Shell Sort**      | O(n log n) / O(n^1.5) / O(n²)        | Faster than Bubble/Insertion; easy to implement                      | Not stable; performance depends on gap sequence                         |
| **Merge Sort**      | O(n log n) / O(n log n) / O(n log n) | Always O(n log n); stable; good for linked lists                     | Uses extra memory (O(n)); slower for small lists                        |
| **Quick Sort**      | O(n log n) / O(n log n) / O(n²)      | Very fast in practice; in-place; O(n log n) average                  | Worst case O(n²); not stable; performance depends on pivot choice        |
| **Heap Sort**       | O(n log n) / O(n log n) / O(n log n) | O(n log n) always; in-place; no extra memory                         | Not stable; slower than QuickSort in practice                           |
| **Counting Sort**   | O(n+k) / O(n+k) / O(n+k)             | O(n+k) time; very fast for small integer ranges                      | Only works for integers in a known range; uses extra memory             |
| **Bucket Sort**     | O(n+k) / O(n+k) / O(n²)              | Good for uniformly distributed data; can be very fast                | Not good for non-uniform data; needs extra memory                       |
| **Radix Sort**      | O(nk) / O(nk) / O(nk)                | O(nk) time; good for large numbers/strings; not comparison-based     | Only for integers/strings; needs stable sort as subroutine              |
| **TimSort**         | O(n) / O(n log n) / O(n log n)        | Hybrid (Merge + Insertion); used in Python/Java; very efficient      | Complex to implement; not always best for all data types                |
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

## Contribution

Feel free to suggest improvements or ask questions! 