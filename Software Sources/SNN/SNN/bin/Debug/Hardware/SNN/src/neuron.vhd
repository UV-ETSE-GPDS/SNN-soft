library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_unsigned.all;
use WORK.globals.all;

entity neuron is  
	GENERIC (inputs_number : natural := input_number;
			 weights_offset: natural := 0;	  -- to move along	weight table should be set according to rule: i*(number of neurons in previous layer), where i is neuron indes in layer  
			 which_layer : natural := 0); -- assigned dependent on to which layer neuron belongs to
	port(
		inputs : in std_logic_vector(0 to inputs_number - 1);
	    clk    : in std_logic;
		clk_fast : in std_logic;
		reset : in std_logic;
		spike : out std_logic
	);
	
end neuron;

architecture neuron of neuron is

component potentialControl
		port(
		potential_To_Compare : in data_type;
		clk : in std_logic;
		reset : in std_logic;
		in_refractory :	out std_logic;
		fire_spike : out std_logic
	);		 
end component;

component psp_generator_basic
		generic(weight_init : std_logic_vector(num_bits - 1 downto 0));
		port( clk : in std_logic;
		  reset   : in std_logic;
		  delayed_spike : in std_logic;				   
		  weight: inout std_logic_vector;
		  refractory : in std_logic;
		  potential : out data_type
		 );
	
end component; 	

component potential_mux
		generic(inputs_number : natural);
		port(
		psp_lines : in wires(0 to inputs_number); 
		weights_lines : in wires(0 to inputs_number);
		reset : in std_logic;
		fast_clk : in std_logic; 
		clk : in std_logic;	
		end_add : out std_logic;
		output_to_sumator : out data_type);
end component;

component addUnit
	port( 
		  A,B : in data_type;
		  LOAD : in std_logic;	   
		  fast_clk  : in std_logic;	 
		  end_add : in std_logic;
		  refractor : in std_logic;
		  P : out data_type);
end component;
																	 
signal wires_from_generators_to_adder : wires(0 to inputs_number);

signal faster_clk_s : std_logic;  
signal refractory_s : std_logic;
signal fire_spike_s : std_logic; 
signal spike_s : std_logic; 

signal clk_s : std_logic;

signal delayed_spike_s : std_logic;				   
signal weight_s : wires(0 to inputs_number);

signal potential_s : data_type;
signal A_s,B_s : data_type;
signal LOAD_S : std_logic;	   
signal P_S : data_type;		  
signal end_add_s : std_logic;
signal zero_spike : std_logic := '0';

begin									   
	
	psp0: psp_generator_basic generic map (weight_init=>WORK.globals.zero) port map (clk=>clk,reset=>reset,delayed_spike=>zero_spike,weight=>weight_s(0),refractory=>refractory_s,potential=>wires_from_generators_to_adder(0));
	gen_if_layer1: if which_layer = 0 generate
		map_psps : for i in 0 to inputs_number - 1 generate
			psp_bck: block
				for all: psp_generator_basic use entity work.psp_generator_basic;
			begin
				psp: psp_generator_basic generic map (weight_init=>lay1_weights(i+weights_offset)) port map (clk=>clk,reset=>reset,delayed_spike=>inputs(i),weight=>weight_s(i+1),refractory=>refractory_s,potential=>wires_from_generators_to_adder(i+1));
			end block;
		end generate;
	end generate gen_if_layer1;
	
	gen_if_output: if which_layer = 1 generate
		map_psps : for i in 0 to layer1_number - 1 generate
			psp_bck: block
				for all: psp_generator_basic use entity work.psp_generator_basic;
			begin
				psp: psp_generator_basic generic map (weight_init=>out_weights(i+weights_offset)) port map (clk=>clk,reset=>reset,delayed_spike=>inputs(i),weight=>weight_s(i+1),refractory=>refractory_s,potential=>wires_from_generators_to_adder(i+1));
			end block;
		end generate;
	end generate gen_if_output;
	
	map_mux : potential_mux generic map (inputs_number => inputs_number) port map(psp_lines=>wires_from_generators_to_adder,weights_lines=>weight_s,reset=>reset,fast_clk=>clk_fast,clk=>clk,end_add=>end_add_s,output_to_sumator=>A_s);	
	
	map_adder : addUnit port map(A=>A_s,B=>P_s,LOAD=>reset,fast_clk=>clk_fast,end_add=>end_add_s,refractor=>refractory_s,P=>P_s);
	
	map_comparator : potentialControl port map(potential_To_Compare=>P_s,clk=>clk,reset=>reset,in_refractory=>refractory_s,fire_spike=>spike);

	
end neuron;
