const const_pi=3.14;
const not_important="bla bla bla";


function add(num1, num2){
    return num1+num2;
}

const substract=(num1,num2)=>{
    return num1-num2;
}

module.exports={
    pi: const_pi,
    sum: add,
    substract: substract

}

exports.pi=const_pi
exports.sum=add;
