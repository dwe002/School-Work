// NAND gate function
module NANDgate (A, B, Q);

    // input variables for verilog
    input A, B;
     // output variable for verilog
    output Q;

    //assigns variable Q equal to NOT(A AND B) 
    assign Q = !(A&B);

endmodule

// NOR gate function
module NORusingNAND (A, B, Q);

    // indicates inputs and outputs to verilog
    input A, B;
    output Q;

    // intitilzed wires
    wire C, D, E, F;

    // NOR gate from NAND gates
    NANDgate u1(A, A, C);
    NANDgate u2(B, B, D);
    NANDgate u3(C, D, E);
    NANDgate u4(E, E, F);

    // assigns Q equal to F
    assign Q = F;

endmodule