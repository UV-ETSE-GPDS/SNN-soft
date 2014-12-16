library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_signed.all;
use WORK.globals.all;

entity addUnit is 	  --overload is not considered, one should be careful to not cross max permited value
	port( A,B : in data_type;
		  LOAD : in std_logic;	   
		  fast_clk  : in std_logic;
		  end_add 		: in std_logic;
		  refractor : in std_logic;
		  P : out data_type);
end addUnit;

architecture addUnit_archi of addUnit is 
	signal partialSum : data_type;	   
begin	   
	
	process (LOAD,fast_clk,end_add)
	begin
	if(rising_edge(fast_clk)) then
		if((LOAD = '0') or (refractor = '1') or (end_add = '1'))then
	 		partialSum <= zero;
		else
			partialSum <=  A + B;			
		end if;
	end if;
	end process;   
	
	P <= partialSum;
end addUnit_archi;