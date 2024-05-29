 //initialize wires
 module mux_4x1(a, b, c, d, sel0, sel1, out);

    // input wires
    input a, b, c, d, sel0, sel1;
    // output wire
    output out;

    /* wire out will be equal to the turnary operand of 
    sel1 to two nested turnary operand sel0, d c and sel0, b a */
    assign out = sel1 ? (sel0 ? d : c) : (sel0 ? b : a);

 endmodule