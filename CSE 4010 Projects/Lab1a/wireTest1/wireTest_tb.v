//craetes time limit and includes the wireTest.v file
`timescale 1 ns / 1 ns
`include "wireTest.v"

//creates test bench
module wireTest_tb;

//denotes wires A, B, and C
reg A;
wire B;
wire C;

//creates instance of wireTest
wireTest uut(A, B, C);

initial begin

    //creates a seperate .vvp file and .vcd file for outputs
    $dumpfile("wireTest_tb.vcd");
    $dumpvars(0, wireTest_tb);

    A = 0; //sets A to 0
    #20 //wait 20 nano seconds

    A = 1; //sets A to 1
    #20 //wait 20 nano seconds

    A = 0; //sets A to 0
    #20 //wait 20 nano seconds

    A = 1; //sets A to 1
    #20 //wait 20 nano seconds

    //displays message to terminal
    $display("Wire tests complete!");

end

endmodule