import sys
import test_io


def a_plus_pow_b(list):
    res = []
    for l in list:
        str_arr = str.split(l, " ")
        res.append(int(str_arr[0]) + pow(int(str_arr[1]), 2))
    return res


if __name__ == "__main__":
    path = sys.argv[1]
    input_list = test_io.read_in(path)
    result = a_plus_pow_b(input_list)
    test_io.write_out(result, path)