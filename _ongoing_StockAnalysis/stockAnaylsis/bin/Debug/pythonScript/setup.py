from cx_Freeze import setup, Executable

includefiles = ['phantomjs.exe']

setup(name='googleFinance',
      version='0.1',
      author = 'Seunghyun Yoo',
      author_email = 'shstyoo@gmail.com',
      options = {'build_exe': {'include_files':includefiles}},
      executables = [Executable("googleFinancePhantomJS.py")])
