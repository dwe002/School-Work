//intitalizing wires A, B, and C
module wireTest (A, B, C); 

    //input wire is A
    input A; 
    //output wires ared B and C
    output B;
    output C;

    //wire B will be the same as wire A
    assign B = A;
    //wire C will be the opposite as wire A
    assign C = !A;

endmodule

