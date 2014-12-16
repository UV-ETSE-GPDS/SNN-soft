library IEEE;
use IEEE.std_logic_1164.all;
use IEEE.std_logic_arith.all;
use IEEE.std_logic_signed.all;
use WORK.globals.all;

entity mulUnit is 
	port( A,B : in data_type;
	P : out data_type);--std_logic_vector((2 *data_int'length) - 1 downto 0));
end mulUnit;

architecture mulUnit_archi of mulUnit is 

signal mult_int: std_logic_vector((2 *data_type'length) - 1 downto 0);

begin	
	mult_int <= A*B;
	P <= mult_int((2 * data_type'length) - ((num_bits - codingPower) + 1) downto data_type'length - ((num_bits - codingPower)));
end mulUnit_archi;
			
