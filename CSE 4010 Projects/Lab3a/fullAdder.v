//initialize wires
module halfAdder(op1, op2, sum, carry);

    //input wires
    input op1, op2;
    //output wires
    output sum, carry;

    //wire sum will be the same as the exclusive or of wires op1 and op2 
    assign sum = op1 ^ op2; // "^" = XOR operator
    //wire sum will be the same as the anding of wires op1 and op2 
    assign carry = op1 & op2; // "&" = AND operator    

endmodule

module fullAdder(A, B, carryIn, sum, carryOut);

    //input and output wires
    input A, B, carryIn;
    output sum, carryOut;

    //intermediary wires
    wire c, d, e;

    //half adder wire definitions for full adder 
    halfAdder u1(A, B, c, d);
    halfAdder u2(carryIn, c, e, f);

    //wire carryOut will be the same as the or of wires op1 and op2
    assign carryOut = f | d;
    //wire sum will be the same as wire e
    assign sum = e;

endmodule