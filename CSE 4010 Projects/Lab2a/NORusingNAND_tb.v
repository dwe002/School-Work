// time limit and include .v file
`timescale 1ns/1ns
`include "NORusingNAND.v"

// test bench
module NORusingNAND_tb;

//denotes wires A, B, and Q
reg A;
reg B;
wire Q;

// instance of NORusingNAND
NORusingNAND uut(A, B, Q);

initial begin

    // creates files for outputs
    $dumpfile("NORusingNAND_tb.vcd");
    $dumpvars(0, NORusingNAND_tb);

    A = 0; B = 0; #20 // sets A and B to 0, wait 20 nanoseconds
    A = 0; B = 1; #20 // sets A to 0 and B to 1, wait 20 nanoseconds
    A = 1; B = 0; #20 // sets A to 1 and B to 0, wait 20 nanoseconds
    A = 1; B = 1; #20 // sets A to 1 and B to 1, wait 20 nanoseconds

    //displays message to terminal
    $display("Complete!");
    
end

endmodule