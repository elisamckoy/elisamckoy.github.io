# Triangle Debugger

# Original Solution

def valid_triangle?(a, b, c, sum)
  if a != 0 || b != 0 || c != 0
  if a >= b
  largest = a
  sum += b
  else largest = b
  sum += a
  end
  if c > largest
  sum += largest
  largest = c
  else sum += c
  end
  if sum > largest
  return "true"
  else return "false"
  end
  else return "false"
  end
end


# Answer the question for each bug

# --- Bug 1 ---
# * what is the exact description of the error?
# * what is the exact line number the error is appearing?
# * before you fix the bug, what do you think is causing the error?

# --- Bug 2 ---
# * what is the exact description of the error?
# * what is the exact line number the error is appearing?
# * before you fix the bug, what do you think is causing the error?

# --- Bug 3 ---
# * what is the exact description of the error?
# * what is the exact line number the error is appearing?
# * before you fix the bug, what do you think is causing the error?


# Your Refactored Solution (Comment the other code to run this)




# DRIVER TESTS GO BELOW THIS LINE
