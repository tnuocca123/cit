import re
import sys


def read_in(input):
    result = []
    with open(input, 'r') as reader:
        for line in reader:
            result.append(line.strip("\n"))
        reader.close()
    return result


def write_out(list, path):
    out_path = re.sub(r'(.*/?)(input)(\d+\.txt)', r'\1output\3', path)
    with open(out_path, 'wr') as file:
        for s in list:
            file.write(str(s)+"\n")
        file.close()


# if __name__ == "__main__":
#     print(read_in(sys.argv[1]))
#     write_out("", sys.argv[1])
