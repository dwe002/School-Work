//creates time limit and include mux4x1.v file
`timescale 1 ns / 1 ns
`include "mux4x1.v"

//creates test bench
module mux4x1_tb;

//denoted wires
reg A, B, C, D, Sel0, Sel1;
wire O;

//creates instance of mux4x1
mux_4x1 uut(A, B, C, D, Sel0, Sel1, O);

initial begin

    //creates a separate .vvp file and .vcd file for outputs
    $dumpfile("mux4x1_tb");
    $dumpvars(0, mux4x1_tb);

    //mux 4x1
    A = 0; B = 1; C = 0; D = 1;
    {Sel1, Sel0} = 2'd0; #20;
    {Sel1, Sel0} = 2'd1; #20;
    {Sel1, Sel0} = 2'd2; #20;
    {Sel1, Sel0} = 2'd3; #20;
    
    //displays message to terminal
    $display("Complete!");

end

endmodule




