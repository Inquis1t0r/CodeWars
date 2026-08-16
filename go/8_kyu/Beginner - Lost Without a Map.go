package kata

func Maps(x []int) []int {
	result := make([]int, len(x))
	for index, element := range x {
		result[index] = element + element
	}

	return result
}
