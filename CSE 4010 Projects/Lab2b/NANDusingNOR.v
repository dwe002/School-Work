// NOR gate function 
module NORgate (A, B, Q); 

    // input variables for verilog 
    input A, B; 
     // output variable for verilog 
    output Q; 

    // assigns variable Q equal to NOT(A OR B)  
    assign Q = !(A|B); 

endmodule 

// NAND gate function 
module NANDusingNOR (A, B, Q); 

    // indicates inputs and outputs to verilog 
    input A, B; 
    output Q; 

    // intitilzed wires 
    wire C, D, E, F; 

    // NAND gate from NOR gates
    NORgate u1(A, A, C); 
    NORgate u2(B, B, D); 
    NORgate u3(C, D, E); 
    NORgate u4(E, E, F); 

    // assigns Q equal to F 
    assign Q = F; 

endmodule 