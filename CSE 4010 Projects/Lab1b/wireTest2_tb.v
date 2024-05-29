//creates time limit and includes the wireTest2.v file
`timescale 1 ns / 1 ns
`include "wireTest2.v"

//creates test bench
module wireTest2_tb;

//denotes wires W, X, Y, and Z
reg W;
reg X;
wire Y;
wire Z;

//creates instance of wireTest
wireTest2 uut(W, X, Y, Z);

initial begin

    //creates a seperate .vvp file and .vcd file for outputs
    $dumpfile("wireTest2_tb.vcd");
    $dumpvars(0, wireTest2_tb);

    W = 0; //sets W to 0
    X = 0; //sets X to 0
    #20 //wait 20 nanoseconds

    W = 1; //sets W to 0
    #20 //wait 20 nanoseconds

    X = 1; //sets X to 1
    #20 //wait 20 nanoseconds

    W = 0; //sets W to 0
    #20 //wait 20 nanoseconds

    X = 0; //sets X to 0
    #20 //wait 20 nanoseconds

    //displays message to terminal
    $display("Wire tests complete!");

end

endmodule
