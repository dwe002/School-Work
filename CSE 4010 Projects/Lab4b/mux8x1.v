 //initialize wires
 module mux_8x1(a, b, c, d, e, f, g, h, sel0, sel1, sel2, out);

    // input wires
    input a, b, c, d, e, f, g, h, sel0, sel1, sel2;
    // output wire
    output out;

    /* wire out will be equal to the turnary operand of sel2 to two nested turnary operand of sel1 
    with two other nested turnary operand of sel0 and corresponding letters*/
    assign out = sel2 ? (sel1 ? (sel0 ? h : g) : (sel0 ? f : e)) : (sel1 ? (sel0 ? d : c) : (sel0 ? b : a));

 endmodule