import urllib
import time
from selenium import webdriver 
from selenium.webdriver.common.keys import Keys
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

#This will grab all pertinent information from user
print("\nThis is the Selenium driver to grab stock information from Google Finance\n")
x = raw_input("What stock are you searching for?: ")

print("\nNow searching for " + x + " \nPlease give the range of dates to pull historical data from\nIn format mmddyyyy")

cont = False
while(cont == False):
	cont2 = True

	cont3 = False
	while(cont3 == False):
		cont4 = True
		y = raw_input("\nStart Date: ")
		z = raw_input("\nEnd Date: ")

		#Check to make sure that no char are in the date
		def is_number(s):
			try:
				int(s)
				return True
			except ValueError:
				return False
		
		#Debugging
		print(is_number(z))
		print(is_number(y))
		#Debugging

		if(is_number(z) == False or is_number(y) == False):
			print("\nYour date contains letters! (Follow the format: mmddyyy)\n")
			cont4 = False

		#This checks to see whether or not the string length is long enough
		if(len(y) < 8 or len(z) < 8):
			print("\n\nYour date is too short! (Follow the format: mmddyyy)\n")
			cont4 = False

		if(cont4 == False):
			cont3 = False
		else:
			cont3 = True

	#This just checks whether a month has 30 days (even) or 31 days (odd) Feb not included
	start_date_isEven = 	True 
	end_date_isEven = 	True

	#This takes the user input and creates three separate strings to be evaluated
	start_date_month = 	y[0]+y[1]
	start_date_day =	y[2]+y[3]
	start_date_year =	y[4]+y[5]+y[6]+y[7]

	end_date_month = 	z[0]+z[1]
	end_date_day = 		z[2]+z[3]
	end_date_year = 	z[4]+z[5]+z[6]+z[7]

	#Checks to see if user input valid month (Start)
	if(start_date_month == "01"):
		start_date = "Jan"
		start_date_isEven = False
	elif(start_date_month == "02"):
		start_date = "Feb"
		start_date_isEven = False
	elif(start_date_month == "03"):
		start_date = "Mar"
		start_date_isEven = False
	elif(start_date_month == "04"):
		start_date = "Apr"
		start_date_isEven = True
	elif(start_date_month == "05"):
		start_date = "May"
		start_date_isEven = False
	elif(start_date_month == "06"):
		start_date = "Jun"
		start_date_isEven = True
	elif(start_date_month == "07"):
		start_date = "Jul"
		start_date_isEven = False
	elif(start_date_month == "08"):
		start_date = "Aug"
		start_date_isEven = False
	elif(start_date_month == "09"):
		start_date = "Sep"
		start_date_isEven = False
	elif(start_date_month == "10"):
		start_date = "Oct"
		start_date_isEven = True
	elif(start_date_month == "11"):
		start_date = "Nov"
		start_date_isEven = False
	elif(start_date_month == "12"):
		start_date = "Dec"
		start_date_isEven = True
	else:
		print("\nYour input is not recognized as a month (01-12)\n")
		cont2 = False

	#Checks to see if user input valid month (End)
	if(end_date_month == "01"):
		end_date = "Jan"
		end_date_isEven = False
	elif(end_date_month == "02"):
		end_date = "Feb"
		end_date_isEven = False
	elif(end_date_month == "03"):
		end_date = "Mar"
		end_date_isEve = False
	elif(end_date_month == "04"):
		end_date = "Apr"
		end_date_isEve = True
	elif(end_date_month == "05"):
		end_date = "May"
		end_date_isEve = False
	elif(end_date_month == "06"):
		end_date = "Jun"
		end_date_isEve = True
	elif(end_date_month == "07"):
		end_date = "Jul"
		end_date_isEve = False
	elif(end_date_month == "08"):
		end_date = "Aug"
		end_date_isEve = False
	elif(end_date_month == "09"):
		end_date = "Sep"
		end_date_isEve = False
	elif(end_date_month == "10"):
		end_date = "Oct"
		end_date_isEve = True
	elif(end_date_month == "11"):
		end_date = "Nov"
		end_date_isEve = False
	elif(end_date_month == "12"):
		end_date = "Dec"
		end_date_isEve = True
	else:
		print("\nYour input is not recognized as a month (01-12)\n")
		cont2 = False

	#Checks to see if user input valid day (Start)
	if(int(start_date_month) == 02):
		if(int(start_date_day) > 28 or int(start_date_day) < 0):
			print("\nYour date is not recognized as a day in this month (01-28)\n")
			cont2 = False
	elif(start_date_month == False):
		if(int(start_date_day) > 31 or int(start_date_day) < 0):
			print("\nYour date is not recognized as a day in this month (01-31)\n")
			cont2 = False
	elif(start_date_month == True):
		if(int(start_date_day) > 30 or int(start_date_day) < 0):
			print("\nYour date is not recognized as a day in this month (01-30)\n")
			cont2 = False

	#Checks to see if user input valid day (End)
	if(int(end_date_month) == 02):
		if(int(end_date_day) > 28 or int(end_date_day) < 0):
			print("\nYour date is not recognized as a day in this month (01-28)\n")
			cont2 = False
	elif(end_date_month == False):
		if(int(end_date_day) > 31 or int(end_date_day) < 0):
			print("\nYour date is not recognized as a day in this month (01-31)\n")
			cont2 = False
	elif(end_date_month == True):
		if(int(end_date_day) > 30 or int(end_date_day) < 0):
			print("\nYour date is not recognized as a day in this month (01-30)\n")
			cont2 = False

	#Checks to see if user input valid year
	if(int(start_date_year) > int(end_date_year)):
		print("\nYou can't have an end date that occurs earlier than the start date\n")
		cont2 = False
	elif(int(start_date_year) == int(end_date_year)):
		if(int(start_date_day) > int(end_date_day)):
			print("\nYou can't have an end date that occurs earlier than the start date\n")
			cont2 = False
	
	#Checks for general input error. REMEMBER TO UPDATE ELIF (2) to change per year (from 2014 -> 2015 once the time is right)
	if(len(y) > 8 or len(x) > 8):
		print("\nYour input is too long! (Follow the format: mmddyyy)")
		cont2 = False
	elif(int(start_date_year) > 2014 or int(start_date_year) < 1600):
		print("\nPlease select a reasonable date range between 1600-2014")
		cont2 = False
	
	#Checks to see if any errors were met
	if(cont2 == False):
		cont = False
	else:
		cont = True

#Created user start/end dates
startDate = start_date + " " + start_date_day + ", " + start_date_year
endDate = end_date + " " + end_date_day + ", " + end_date_year

print("\nFinding values for " + x + " from " + startDate + " to " + endDate + "\n" )
#Debugging
#print(startDate)
#print(endDate)
#Debugging

#END OF USER INPUT EDITING

#This is the Selenium Webdriver portion of the Python code

driver = webdriver.PhantomJS('phantomjs.exe')
driver.get("http://www.google.com/finance")

elem = driver.find_element_by_id('gbqfq')

elem.send_keys(x)
elem.send_keys(Keys.RETURN)

option = driver.find_element_by_link_text('Historical prices')
option.click()

option2 = driver.find_element_by_id('hfs')

elem2 = driver.find_element_by_class_name("id-fromdate")
elem2.send_keys(Keys.CONTROL + "a")
elem2.send_keys(Keys.DELETE)
elem2.send_keys(startDate)

elem3 = driver.find_element_by_class_name("id-todate")
elem3.send_keys(Keys.CONTROL + "a")
elem3.send_keys(Keys.DELETE)
elem3.send_keys(endDate)

option2.click()

#This little tidbit of code just checks every 0.5 seconds to see if an element by the name "nowrap" exists on the page, for 10 seconds
try:
	option3 = WebDriverWait(driver, 15).until(EC.presence_of_element_located((By.CLASS_NAME, "nowrap"))).get_attribute("href");
except:
	print("\nCould not find element in time.\n")

urllib.urlretrieve(option3, x+".csv")

driver.quit()
