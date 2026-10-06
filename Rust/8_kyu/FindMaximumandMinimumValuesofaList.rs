fn minimum(arr: &[i32]) -> i32 {

    let minValue = arr.iter().min();
    return *minValue.unwrap();
}

fn maximum(arr: &[i32]) -> i32 {

    let maxValue = arr.iter().max();
    return *maxValue.unwrap();
}
