//creates time limit and include mux8x1.v file
`timescale 1 ns / 1 ns
`include "mux8x1.v"

//creates test bench
module mux8x1_tb;

//denoted wires
reg A, B, C, D, E, F, G, H, Sel0, Sel1, Sel2;
wire O;

//creates instance of mux8x1
mux_8x1 uut(A, B, C, D, E, F, G, H, Sel0, Sel1, Sel2, O);

initial begin

    //creates a separate .vvp file and .vcd file for outputs
    $dumpfile("mux8x1_tb");
    $dumpvars(0, mux8x1_tb);

    //mux 8x1
    A = 0; B = 1; C = 0; D = 1; E = 0; F = 1; G = 0; H = 1;
    {Sel2, Sel1, Sel0} = 3'd0; #20;
    {Sel2, Sel1, Sel0} = 3'd1; #20;
    {Sel2, Sel1, Sel0} = 3'd2; #20;
    {Sel2, Sel1, Sel0} = 3'd3; #20;
    {Sel2, Sel1, Sel0} = 3'd4; #20;
    {Sel2, Sel1, Sel0} = 3'd5; #20;
    {Sel2, Sel1, Sel0} = 3'd6; #20;
    {Sel2, Sel1, Sel0} = 3'd7; #20;
    
    //displays message to terminal
    $display("Complete!");

end

endmodule
