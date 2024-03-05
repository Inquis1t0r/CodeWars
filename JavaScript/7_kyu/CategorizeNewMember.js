function openOrSenior(data){
  const resultArray = [];
  console.dir(data);
  for(member of data){
    resultArray.push(isSenior(member) ? 'Senior' : 'Open');
  }
  return resultArray;
}

function isSenior(memberData){
  return memberData[0] >= 55 && memberData[1] > 7 ;
}
