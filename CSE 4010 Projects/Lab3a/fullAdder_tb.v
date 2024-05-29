//creates time limit and include fullAdder.v file
`timescale 1 ns / 1 ns
`include "fullAdder.v"

//creates test bench
module fullAdder_tb;

//denoted wires
reg A, B, carryIn;
wire sum, caryOut;

//creates instance of fullAdder
fullAdder uut(A, B, carryIn, sum, carryOut);

initial begin

    //creates a separate .vvp file and .vcd file for outputs
    $dumpfile("fullAdder_tb.vcd");
    $dumpvars(0, fullAdder_tb);

    //fullAdder gate
    {A, B, carryIn} = 3'd0; #20; 
    {A, B, carryIn} = 3'd1; #20; 
    {A, B, carryIn} = 3'd2; #20; 
    {A, B, carryIn} = 3'd3; #20; 
    {A, B, carryIn} = 3'd4; #20; 
    {A, B, carryIn} = 3'd5; #20; 
    {A, B, carryIn} = 3'd6; #20; 
    {A, B, carryIn} = 3'd7; #20; 
    //displays message to terminal
    $display("Finished additions!");

end

endmodule
