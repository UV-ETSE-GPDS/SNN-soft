library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_signed.all;
use WORK.globals.all;	

entity synapse is 
	GENERIC (delay : natural := 10);  --delay should be always equal to delay + 1 because 1st step is synapse initialization
	port(
		input : in std_logic;  
		clk	  : in std_logic;
		output : out std_logic;
		reset : in std_logic
	);
	
end entity;

architecture synapse_arch of synapse is	  

--signal queue : std_logic_vector(delay -1 downto 0);
begin 		  	
	
	process (input, clk,reset)
	variable cola : std_logic_vector(delay -1 downto 0);
	begin
	
		if(reset = '0')then
			cola := (others => '0'); 

		elsif(clk'event and clk = '1') then	 
			--queue <= SHL(queue,"1");
			if(input = '1')then
				cola(0) := '1';
			else
				cola(0) := '0';
			end if;	
			cola := SHL(cola,"1");					
		end if;				
	  output <= cola(delay - 1);
	end process;
	
	

end synapse_arch;