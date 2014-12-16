library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_unsigned.all;
use WORK.globals.all;

entity network is
	GENERIC(number_of_layers : natural := 1);
	port(
		network_inputs : in std_logic_vector(0 to input_number - 1);
		reset : in std_logic;
		board_clk : in std_logic;
		network_outputs : out std_logic_vector(0 to output_number - 1) -- wyjeb
	);
	
end network;


architecture network of network is
--######## components section:

component freqDiv
	port(
		external_clk : in std_logic;
    	reset : in std_logic;
		out_clk : inout std_logic	
	);
end component freqDiv;	   

component timer
	port(
	clk : in std_logic;
	reset : in std_logic;
	timer_time : out std_logic_vector(31 downto 0)
	);
end component timer;

component inputNeuron  
	GENERIC(firing_rate : natural := 50);
	port(
		clk : in std_logic;
		reset : in std_logic;
		input : in std_logic;
		spikeTrain : out std_logic
	);	
end component inputNeuron;

component synapse 
	GENERIC (delay : natural := 10);
	port (
		input : in std_logic;  
		clk	  : in std_logic;
		output : out std_logic;
		reset : in std_logic
	);
end component synapse;

component neuron
	GENERIC (inputs_number : natural;
			 weights_offset: natural := 0;	  
			 which_layer : natural := 0
			 );
	port(
		inputs : in std_logic_vector(0 to inputs_number - 1);
	    clk    : in std_logic;
		clk_fast : in std_logic;
		reset : in std_logic;
		spike : out std_logic	
		);
end component neuron;

--######## end of components section.

--signal scetion:

signal clk : std_logic;
signal timer_time : std_logic_vector(31 downto 0);

signal wires_from_input: std_logic_vector(0 to input_number - 1);
signal wires_to_lay1: wires_input_to_layer1;

signal wires_from_layer1: std_logic_vector(0 to layer1_number - 1);
signal wires_to_output : wires_lay1_to_output;

signal wires_from_output : std_logic_vector(0 to output_number - 1);

--end of signal section.


begin
	

	
--components mapping:

	map_frequency_divider : freqDiv port map (external_clk=>board_clk,reset=>reset,out_clk=>clk);
	
	map_timer : timer port map(clk=>clk,reset=>reset,timer_time=>timer_time);
	
	map_input_neurons : for i in 0 to input_number - 1 generate
		input_bck: block
			for all: inputNeuron use entity work.inputNeuron;
		begin
																			  													
			inputN: inputNeuron generic map(firing_rate=>input_delays(i)) port map (clk=>clk,reset=>reset,input=>network_inputs(i),spikeTrain=>wires_from_input(i));
				
		end block;
	end generate;
	
	
	map_input_lay1_synapses : for i in 0 to (input_number - 1) generate
 
		gen_in_lay1_synapses: for j in 0 to  (layer1_number - 1) generate   	
			synapses1_bck: block
				for all: synapse use entity work.synapse;
			begin
				synapse1: synapse generic map(delay=>input_lay1_delays(i + j + (2 * i))) port map (input=>wires_from_input(i),clk=>clk,output=>wires_to_lay1(j)(i),reset=>reset);
			end block;
		end generate;		
	end generate;
	
	--map_neurons_layer1 : for i in 0 to (input_number - 1) generate

		gen_layer1: for j in 0 to  (layer1_number - 1) generate   	
			layer1_bck: block
				for all: neuron use entity work.neuron;
			begin
				neuron1: neuron generic map(inputs_number=>input_number,weights_offset=>(j*input_number),which_layer=>(number_of_layers - 1)) port map (inputs=>wires_to_lay1(j),clk=>clk,clk_fast=>board_clk,reset=>reset,spike=>wires_from_layer1(j));
			end block;
		end generate;		
	--end generate;	  
	
	map_layer1_to_synapses : for i in 0 to (layer1_number - 1) generate
 
		gen_layer_output_synapses: for j in 0 to  (output_number - 1) generate   	
			synapses2_bck: block
				for all: synapse use entity work.synapse;
			begin
				synapse2: synapse generic map(delay=>lay1_output_delays(i + j + (2 * i))) port map (input=>wires_from_layer1(i),clk=>clk,output=>wires_to_output(j)(i),reset=>reset);
			end block;
		end generate;		
	end generate;
	
	gen_output: for j in 0 to  (output_number - 1) generate   	
		output_bck: block
			for all: neuron use entity work.neuron;
			begin
				neuron2: neuron generic map(inputs_number=>layer1_number,weights_offset=>(j*layer1_number),which_layer=>number_of_layers) port map (inputs=>wires_to_output(j),clk=>clk,clk_fast=>board_clk,reset=>reset,spike=>network_outputs(j)); --zamien na: wires_from_output(j)
			end block;
	end generate;	
	
--end of components mapping.
	

end network;
