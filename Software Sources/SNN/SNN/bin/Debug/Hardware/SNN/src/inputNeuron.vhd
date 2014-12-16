library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_signed.all;
use WORK.globals.all;

entity inputNeuron is  	 
	GENERIC(firing_rate : natural := 50);
	port(
		clk : in std_logic;
		reset : in std_logic;
		input : in std_logic;
		spikeTrain : out std_logic
	);
end inputNeuron;


architecture inputNeuron of inputNeuron is
	signal generatedSpike :  std_logic;
	signal timerCounter : std_logic_vector(31 downto 0);
begin

	process(reset,clk) is
	begin
		if(reset = '0')then
			timerCounter <= (others=>'0');
			generatedSpike <= '0';
		elsif(rising_edge(clk))then
			if(input = '1') then
				if(timerCounter = conv_std_logic_vector( firing_rate, 32))  then
					generatedSpike <= '1'; 		
					timerCounter <= (others => '0');
				elsif(timerCounter = "1") then
					generatedSpike <= '0';
					timerCounter <= timerCounter + 1;
				else
					generatedSpike <= '0';
					timerCounter <= timerCounter + 1;
				end if;
			else
				timerCounter <= (others => '0'); 
			end if;
		end if;
	end process;
	

spikeTrain <= generatedSpike;

end inputNeuron;
