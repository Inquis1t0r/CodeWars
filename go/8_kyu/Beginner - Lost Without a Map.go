package kata

func Maps(nums []int) []int {
	result := make([]int, 0, len(nums))
	for _, n := range nums {
		result = append(result, n+n)
	}
	return result
}
