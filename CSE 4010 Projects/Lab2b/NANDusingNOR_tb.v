// time limit and include .v file 
`timescale 1ns/1ns 
`include "NANDusingNOR.v" 

// test bench 
module NANDusingNOR_tb; 

//denotes wires A, B, and Q 
reg A; // input 
reg B; // input 
wire Q; // output 

// instance of NANDusingNOR 
NANDusingNOR uut(A, B, Q); 

initial begin 

    // creates files for outputs 
    $dumpfile("NANDusingNOR_tb.vcd"); 
    $dumpvars(0, NANDusingNOR_tb); 

    A = 0; B = 0; #20 // sets A and B to 0, wait 20 nanoseconds 
    A = 0; B = 1; #20 // sets A to 0 and B to 1, wait 20 nanoseconds 
    A = 1; B = 0; #20 // sets A to 1 and B to 0, wait 20 nanoseconds 
    A = 1; B = 1; #20 // sets A to 1 and B to 1, wait 20 nanoseconds 

    //displays message to terminal 
    $display("Complete!");  

end 

endmodule 