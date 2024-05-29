//creates time limit and include fullSubtractor.v file
`timescale 1 ns / 1 ns
`include "fullSubtractor.v"

//creates test bench
module fullSubtractor_tb;

//denoted wires
reg A, B, Bin;
wire diff, Bout;

//creates instance of fullSubtractor
fullSubtractor uut(A, B, Bin, diff, Bout);

initial begin

    //creates a separate .vvp file and .vcd file for outputs
    $dumpfile("fullSubtractor_tb.vcd");
    $dumpvars(0, fullSubtractor_tb);


    //fullSubtractor gate
    {A, B, Bin} = 3'd0; #20;
    {A, B, Bin} = 3'd1; #20;
    {A, B, Bin} = 3'd2; #20;
    {A, B, Bin} = 3'd3; #20;
    {A, B, Bin} = 3'd4; #20;
    {A, B, Bin} = 3'd5; #20;
    {A, B, Bin} = 3'd6; #20;
    {A, B, Bin} = 3'd7; #20;
    //displays message to terminal
    $display("Finished subtractions!");
end
endmodule
