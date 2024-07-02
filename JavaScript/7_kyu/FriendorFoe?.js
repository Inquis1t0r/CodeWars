function friend(friends){
  const result = [];
  for(const friend of friends){
    if(friend.length === 4){
      result.push(friend);
    }
  }
  return result;
}
