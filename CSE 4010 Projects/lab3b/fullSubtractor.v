//initialize wires
module halfSubtractor(op1, op2, diff, borrow);


    //input wires
    input op1, op2;
    //output wires
    output diff, borrow;


    //wire diff will be the same as the exclusive or of wires op1 and op2
    assign diff = op1 ^ op2; // "^" = XOR operator
    //wire borrow will be the same as the and of wires not op1 and op2
    assign borrow = !op1 & op2; // "&" = AND operator, "!" = NOT operator    


endmodule

module fullSubtractor(A, B, Bin, diff, Bout);


    //input and output wires
    input A, B, Bin;
    output diff, Bout;


    //intermediary wires
    wire c, d, e;


    //half subtractor wire definitions for full subtractor
    halfSubtractor u1(A, B, c, d);
    halfSubtractor u2(Bin, c, e, f);


    //wire Bout will be the same as the or of wires f and d
    assign Bout = f | d;
    //wire diff will be the same as wire e
    assign diff = e;

endmodule
