//initialize wires W, X, Y, and Z
module wireTest2 (W, X, Y, Z); 

    //input wires are W and X
    input W;
    input X; 
    //output wires are Y and Z
    output Y;
    output Z;

    //wire Y will be the opposite as wire X
    assign Y = !X;
    //wire Z will be the opposite as wire Y
    assign Z = !Y;

endmodule
